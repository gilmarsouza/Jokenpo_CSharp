using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace Jokenpo
{
    //Classe Remota que será declarada (criada) pela aplicação servidor e chamada pelos cliente
    //Na linguagem C#, o tipo "MarshalByRefObject" define que a classe pode ser acessada remotamente
    public class Servidor: MarshalByRefObject
    {
     //Declaração de Variáveis - Início
        private Jogo jogo;
        public bool rodadaOk; //Determina se a rodada foi executada (flag para o cliente)
        public bool placarOk; //Determina se o placar foi carregado corretamente no RestaurarDisputa
        public int vencedor;
        private MySqlConnection conexao = new MySqlConnection("server = localhost; port = 3306;" +
                                                              "database = dbJokenpo;" +
                                                              "uid = root;" +
                                                              "pwd = root;");
        private MySqlCommand comando;
        private MySqlDataReader busca;
     //Declaração de Variáveis - Fim

        //Método Construtor - Inicializado pelo primeiro cliente que acesso o objeto remoto
        public Servidor()
        {
            try
            {
                jogo = new Jogo();
                jogo.InicializarJogo();
                this.placarOk = false;
                GerarLog(DateTime.Now.ToString() + ": Servidor Online...");
            }
            catch (Exception e)
            {
                GerarLog(DateTime.Now.ToString() + ": " + e.ToString());
                throw e ;
            }
        }

        //Método auxiliar para gravar as mensagem de Log no arquivo
        private void GerarLog(string mensagem)
        {
            //O Bloco "using" serve para abrir o arquivo e fechar logo após o seu fim, salvado assim o novo Log
            using (StreamWriter logServidor = new StreamWriter(@"C:\Jokenpo\logServidor.txt", true))
            {
                logServidor.WriteLine(mensagem);
            }
        }

        //Valida o usuário no Banco
        private int ValidarUsuario(string login, string senha) 
        {
            int retorno = 0;
            try 
            {
                using (comando = conexao.CreateCommand())
                {
                    conexao.Open();
                    comando.CommandText = @"SELECT ID FROM USUARIOS WHERE LOGIN  = ?Login AND SENHA  = ?Senha";
                    comando.Parameters.AddWithValue("Login", login);
                    comando.Parameters.AddWithValue("Senha", senha);
                    busca = comando.ExecuteReader();

                    //Se a busca trouxe um resultado, o usuário existe no banco, logo seu login
                    //e senha foram inseridos corretamente (critérios da Busca no SQL acima)
                    if (busca.HasRows)
                        while (busca.Read())
                            retorno = Convert.ToInt32(busca["ID"]); //Devolve o ID do usuário no banco
                }
                conexao.Close();
            }
            catch (Exception e) {
                GerarLog(DateTime.Now.ToString() + ": " + e.ToString());
            }

            return retorno;
        }

        //Método chamado pelo cliente para se conectar ao jogo
        public int ConectarJogador(string nome, string senha)
        {
            int retorno = ValidarUsuario(nome, senha); //Valida Usuário e Senha
            
            //Caso 1 ou 2, ele será considerado conectado
            if (retorno > 0){
                if (jogo.jogador1.conectado == false)
                {
                    jogo.jogador1.id = retorno;
                    jogo.jogador1.nome = nome;
                    jogo.jogador1.conectado = true;
                    retorno = jogo.jogador1.numeroJogador;
                }
                else if (jogo.jogador2.conectado == false)
                {
                    jogo.jogador2.id = retorno;
                    jogo.jogador2.nome = nome;
                    jogo.jogador2.conectado = true;
                    retorno = jogo.jogador2.numeroJogador;
                }

                if (jogo.jogador1.conectado && jogo.jogador2.conectado)
                {
                    //Agora que temos dois jogadores online, identificar a disputa unindo a id dos dois jogadores
                    //Esse id será utilizado para restaurar partidas anteriores entre esses dois jogadores;
                    if (jogo.jogador1.id < jogo.jogador2.id)
                        jogo.id_Disputa = Convert.ToInt32(jogo.jogador1.id.ToString() + jogo.jogador2.id.ToString());
                    else
                    {
                        jogo.id_Disputa = Convert.ToInt32(jogo.jogador2.id.ToString() + jogo.jogador1.id.ToString());
                    }

                    jogo.RestaurarDisputa(); //Busca no banco os dados da ultima rodada entre os dois jogadores
                    this.placarOk = true;
                }

                //Caso 0: não conectado (Jogadores preenchidos)
                if (retorno > 0)
                    GerarLog(DateTime.Now.ToString() + ": " + nome + " se conectou como Jogador #" + retorno.ToString());
                else
                    GerarLog(DateTime.Now.ToString() + ": " + nome + " tentou se conectar, mas servidor está cheio.");
            }
            else{
                GerarLog(DateTime.Now.ToString() + ": " + nome + " tentou se conectar, mas não foi identificado em nossa base.");
                retorno = -1; //Identifica que o usuário não foi autenticado
            }
            return retorno; //Retorno o número de Jogador para o Cliente
        }

        //Desconecta o Jogador do Jogo, limpando suas variáveis
        public void DesconectarJogador(int NumeroJogador)
        {
            if (NumeroJogador == 1)
                jogo.jogador1.ZerarJogador();
            else
                jogo.jogador2.ZerarJogador();

            jogo.id_Disputa = 0;
            this.placarOk = false;
            GerarLog(DateTime.Now.ToString() + ": Jogador #" + NumeroJogador.ToString() + " se desconectou.");
        }

        //Método invocado pelo cliente para concretizar a jogada do Jogador
        public bool EnviarJogada(int jogador, int jogada) 
        {
            jogo.EfetuarJogada(jogador, jogada);
            GerarLog(DateTime.Now.ToString() + ": Jogador #" + jogador.ToString() + " enviou sua jogada.");

            //Resposta para o cliente saber se pode engatilhar o inicio da partida, caso o outro jogador já tenha efetuada a sua Jogada
            return jogo.JogadoresProntos(); 
        }

        //Verifica se ambos jogadores estão online e se já efetuaram as suas respectivas jogadas na rodada corrente
        public bool JogadoresProntos()
        {
            if (jogo.JogadoresProntos())
            {
                GerarLog(DateTime.Now.ToString() + ": Jogadores prontos...");
                return true;
            }
            else
            {
                this.rodadaOk = false;
                return false;
            }
        }

        //Método que será invocado pelo 2º jogador que efetuar a sua jogada
        //Inicializando a rodada
        public int IniciarRodada() 
        {
            int vencedor = 0;
            try
            {
                vencedor = jogo.IniciarRodada();
            }
            catch (Exception e)
            {
                GerarLog(DateTime.Now.ToString() + ": " + e.ToString());
                throw e;
            }

            if (vencedor == 0)
                GerarLog(DateTime.Now.ToString() + ": Houve Empate nessa Rodada.");
            else
                GerarLog(DateTime.Now.ToString() + ": Vitória do Jogador #" + vencedor.ToString());

            this.rodadaOk = true;
            this.vencedor = vencedor;

            return this.vencedor;
        }

        //Retorna o Histórico temporário para o cliente invocador
        public DataTable RetornaPlacar() 
        {
            return jogo.RetornaResultados();
        }

        //Método utilizado pela Thread na Interface do Cliente, que mostra a conexão de ambos os jogadores
        public bool RetornaStatusJogador(int numJogador)
        {
            if (numJogador == 1)
                return jogo.jogador1.conectado;
            else
                return jogo.jogador2.conectado;
        }

        //Método utilizado para atualizar alguns labels na interface dos clientes
        public int[] PontosJogadores()
        {
            int[] pontos;
            if (this.placarOk)
                pontos = new int[] { jogo.jogador1.pontos, jogo.jogador2.pontos };
            else
                pontos = new int[] { 0, 0 };
            return pontos;
        }

    }
}
