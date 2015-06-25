using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Threading;


namespace Jokenpo
{
    //Classe da Interface do cliente
    public partial class ClienteFrm : Form
    {
        Cliente cliente = new Cliente();
        Thread JogadoresOnline;
        int jogada;

        public ClienteFrm()
        {
            InitializeComponent();
            btnJogar.Enabled = false;
        }

        //Ação do Botão Conectar/Desconectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try 
            {
                //Essa primeira condição se baseia no status da conexão do jogador para definir 
                //se a sua ação será "Conectar" ou "Desconectar"
                if (cliente.statusConexao == false) //Ação "Conectar"
                {
                    //Algumas validações em relação ao preenchimento dos campos de Autenticação
                    if (txtNome.Text == "" || txtSenha.Text == "")
                        MessageBox.Show("Preencha o seu login e senha antes de se conectar", "Login e/ou Senha em Branco", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else 
                    {
                        if (txtIPServidor.Text == "" || txtPorta.Text == "")
                            MessageBox.Show("Informe o IP do servidor e sua porta para Conexão", "IP do Servidor Inválido", 
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else 
                        {
                            try
                            {
                                //Método que invocará o objeto remoto para conectar o Jogador com os dados preenchidos nos campos
                                //de autenticação
                                cliente.ConectarServidor(txtNome.Text, txtSenha.Text, txtIPServidor.Text + ":" + txtPorta.Text);
                                AtualizarlblStatusConexao(cliente.statusConexao);

                                //O método de conexão atualiza o número do jogador. Caso ele seja menor igual a 0
                                //algum erro aconteceu
                                if (cliente.numJogador <= 0)
                                {
                                    if (cliente.numJogador == -1)
                                        MessageBox.Show("Usuário ou senha incorretos", "Falha na Autenticação", 
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    else
                                        MessageBox.Show("Servidor cheio. Tente novamente mais tarde", "Servidor Cheio", 
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    //Se o jogador foi conectado corretamente, essa thread é executada para 
                                    //verificar o status de ambos os jogadores
                                    JogadoresOnline = new Thread(new ThreadStart(AtualizarJogadoresOnline));
                                    JogadoresOnline.Start();
                                    AtualizarPlacar();
                                }
                            }
                            catch (SqlException e1)
                            {
                                MessageBox.Show(e1.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else //Ação "Desconectar"
                {
                    cliente.DesconectarServidor();
                    AtualizarlblStatusConexao(cliente.statusConexao);
                    //Aborta Thread já que ela não é mais necessária
                    JogadoresOnline.Abort();
                    lblStatusConexao.Text = "Você desconectou do servidor com sucesso";
                    LimparTela();
                    LimparPlacar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão : " + ex.Message);
            }
        }

        //Controla os componentes da Interface do cliente, habilitando e desabilitando-os
        //de acordo com o status de conexão
        private void AtualizarlblStatusConexao(bool status)
        {
            if (status)
            {
                txtNome.Enabled       = false;
                txtSenha.Enabled      = false;
                txtIPServidor.Enabled = false;
                txtPorta.Enabled      = false;
                btnJogar.Enabled      = true;
                btnConectar.Text      = "Desconectar";
                lblStatusConexao.Text = "Você está conectado como o jogador #" + cliente.numJogador;
            } 
            else
            {
                txtNome.Enabled       = true;
                txtSenha.Enabled      = true;
                txtIPServidor.Enabled = true;
                txtPorta.Enabled      = true;
                btnJogar.Enabled      = false;
                btnConectar.Text      = "Conectar";
                lblStatusConexao.Text = "Não foi possível se conectar. Tente novamente mais tarde";
            }
        }

        //Thread que verifica se ambos os jogadores estão conectados, habilitando o botão Jogar caso positivo
        private void AtualizarJogadoresOnline()
        {
            for (; ; )
            {
                //Verifico primeiro se o status dos jogadores realmente mudou
                if (cbJogador1.Checked != cliente.StatusJogador(1))
                    cbJogador1.Checked = !cbJogador1.Checked;
                if (cbJogador2.Checked != cliente.StatusJogador(2))
                    cbJogador2.Checked = !cbJogador2.Checked;

                btnJogar.Enabled = (cbJogador1.Checked && cbJogador2.Checked);

                Thread.Sleep(1000);
            }
        }

        private void LimparTela()
        {
            cbJogador1.Checked = false;
            cbJogador2.Checked = false;
            rbPedra.Checked = true;
            txtNome.Clear();
            txtSenha.Clear();
        }

        //Método que atualiza o GridView e os labels do placar na Interface
        private void AtualizarPlacar()
        {
            dgPlacar.DataSource = null;
            dgPlacar.DataSource = cliente.Historico();
            int[] pontos = cliente.RetornaPontuacao();
            lbPlacarJogador1.Text = pontos[0].ToString();
            lbPlacarJogador2.Text = pontos[1].ToString();
            if (cbJogador1.Checked && cbJogador2.Checked)
            {
                lbNomeJogador1.Text = dgPlacar.Columns[1].HeaderText;
                lbNomeJogador2.Text = dgPlacar.Columns[2].HeaderText;
            }
        }

        private void LimparPlacar()
        {
            dgPlacar.DataSource = null;
            lbPlacarJogador1.Text = "0";
            lbPlacarJogador2.Text = "0";
        }


        //Tratamente das mensagens ao jogador após a rodada ser executada
        private void ResultadoRodada(int vencedor)
        {
            if (vencedor == cliente.numJogador)
            {
                MessageBox.Show("Você venceu! \\o/","Jogador #" + cliente.numJogador + ": Resultado da Rodada", 
                                MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (vencedor == 0)
            {
                MessageBox.Show("Empate!", "Jogador #" + cliente.numJogador + ": Resultado da Rodada", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você Perdeu! =(", "Jogador #" + cliente.numJogador + ": Resultado da Rodada", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarPlacar();
            lblStatusConexao.Text = "Escolha uma opção e clique em Jogar...";
        }

        //Método que é invocado caso o jogador tenha sido o primeiro o jogar na rodada
        //Aguarda o jogada do outro jogador
        private void AguardarOutroJogador()
        {
            int vencedor = -1;
            while (vencedor == -1)
            {
                vencedor = cliente.RetornaVencedor();
                Thread.Sleep(500);
            }
            ResultadoRodada(vencedor);
        }

        //Confirma a seleção Jogada e efetua a mesma no servidor
        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (rbPedra.Checked) {
                jogada = 1;
            } else if (rbPapel.Checked) {
                jogada = 2;
            } else if (rbTesoura.Checked) {
                jogada = 3;
            } else if (rbLagarto.Checked) {
                jogada = 4;
            } else if (rbSpock.Checked)
                jogada = 5;

            //Confirmacao = Determina se o outro jogador já executou a sua jogada
            bool confirmacao = cliente.EfetuarJogada(jogada);

            //Se Sim, pede a execução da partida e verifica se é vencedor
            if (confirmacao)
            {
                try
                {
                    int vencedor = cliente.IniciarRodada();
                    ResultadoRodada(vencedor);
                }
                catch (SqlException e2)
                {
                    MessageBox.Show(e2.ToString(), "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //Se não, entra na thread para verificar server.rodadaok, aguardando a jogada do outro jogador
            {
                string aux = lblStatusConexao.Text;
                lblStatusConexao.Text = "Aguardando a jogada do outro jogador....";
                btnJogar.Enabled = false;
                AguardarOutroJogador();
                btnJogar.Enabled = true;
                lblStatusConexao.Text = aux;
            } 
        }

        //Evento final da aplicação cliente, desconectando o Jogador
        //e abortando a thread caso ele clique em fechar antes de desconectar.
        private void ClienteFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cliente.statusConexao == true)
            {

                cliente.DesconectarServidor();
                JogadoresOnline.Abort();
            }
        }

        //Metodos que mudam a imagem da jogada ao se selecionar os checkbuttons - Início
        private void rbPedra_CheckedChanged(object sender, EventArgs e)
        {
            pbJogada.Image = Jokenpo.Properties.Resources.pedra;
        }

        private void rbPapel_CheckedChanged(object sender, EventArgs e)
        {
            pbJogada.Image = Jokenpo.Properties.Resources.papel;
        }

        private void rbTesoura_CheckedChanged(object sender, EventArgs e)
        {
            pbJogada.Image = Jokenpo.Properties.Resources.tesoura;
        }

        private void rbLagarto_CheckedChanged(object sender, EventArgs e)
        {
            pbJogada.Image = Jokenpo.Properties.Resources.lagarto;
        }

        private void rbSpock_CheckedChanged(object sender, EventArgs e)
        {
            pbJogada.Image = Jokenpo.Properties.Resources.spock;
        }
        //Metodos que mudam a imagem da jogada ao se selecionar os checkbuttons - Fim

    }
}
