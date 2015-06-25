using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading;
using System.Data;

namespace Jokenpo
{
    //Classe intermediária que faz a conexão entre a interface e a classe remota Servidor
    public class Cliente
    {
        public string nome;
        public int numJogador;
        public int jogada;
        public bool statusConexao;
        public Servidor server;

        //Construtor
        public Cliente()
        {
            //Definindo que o canal da Conexão remota será TCP
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            this.LimparJogadorCliente();
        }

        //Utilizado para preparar as variáveis do Cliente
        public void LimparJogadorCliente()
        {
            nome          = "";
            numJogador    = 0;
            jogada        = 0;
            statusConexao = false;
        }

        //Nesse método é que o objeto remoto será invocado pelo cliente
        public void ConectarServidor(string nome, string senha, string endereco)
        {
            try
            {
                //Nesse if garanto o objeto será instanciado apenas uma vez,
                //já que o meu objeto server (que objeto remoto do cliente) ainda está nulo
                if (server == null)
                {
                    //Invocando o objeto remoto, através do seu endereço TCP
                    RemotingConfiguration.RegisterWellKnownClientType(
                    typeof(Servidor),
                    "tcp://" + endereco + "/Jokenpo");

                    //Como o objeto remoto já foi invocado, ao declarar que server
                    //qualquer declaração de objeto Servidor a partir de agora
                    //sempre será relacionado ao mesmo objeto remoto do servidor
                    server = new Servidor();
                }

                this.statusConexao = false;

                //Invocando o objeto remoto para validar o login e senha do usuário
                this.numJogador = server.ConectarJogador(nome, senha);

                if (this.numJogador > 0)
                {
                    this.nome = nome;
                    this.statusConexao = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //informar ao servidor sobre a desconexão
        public void DesconectarServidor()
        {
            server.DesconectarJogador(this.numJogador);
            this.LimparJogadorCliente();
        }


        //Métodos Relacionados com a realização das Jogadas - Início
        public bool EfetuarJogada(int jogada)
        {
            this.jogada = jogada;
            return server.EnviarJogada(this.numJogador, this.jogada);
        }

        public int IniciarRodada()
        {
            return server.IniciarRodada();
        }

        public int RetornaVencedor()
        {
            if (server.rodadaOk)
            {
                server.rodadaOk = false;
                return server.vencedor;
            }
            else
                return -1;
        }
        //Métodos Relacionados com a realização das Jogadas - Fim

        //Métodos utilizados na atualização de alguns campos da interface do cliente - Início
        public bool StatusJogador(int numJogador)
        {
            return server.RetornaStatusJogador(numJogador);
        }

        public DataTable Historico()
        {
            return server.RetornaPlacar();
        }

        public int[] RetornaPontuacao()
        {
            return server.PontosJogadores();
        }
        //Métodos utilizados na atualização de alguns campos da interface do cliente - Fim
    }
}
