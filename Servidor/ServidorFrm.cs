using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Jokenpo {

    //Interface do Servidor
    public partial class ServidorFrm : Form {
        public ServidorFrm() {
            InitializeComponent();
            pbGato.Visible = false;
        }

        //Ação do botão "Iniciar Servidor"
        public void btnIniciar_Click(object sender, EventArgs e) {
            try 
            {
                //Verifica se a porta TCP inserida pela usuário está disponível
                if (DisponibilidadeTCP(txtTCP.Text))
                {
                //Criação do Objeto Remoto baseado na Classe Servidor - Início
                    TcpChannel channel = new TcpChannel(Convert.ToInt32(txtTCP.Text));
                    ChannelServices.RegisterChannel(channel, false);

                    //A Parametrização "Singleton" determina que o objeto a ser criado
                    //será unico. Todos os clientes chamarão a mesma instancia do objeto
                    RemotingConfiguration.RegisterWellKnownServiceType(
                        typeof(Servidor),
                        "Jokenpo",
                        WellKnownObjectMode.Singleton);
                //Criação do Objeto Remoto baseado na Classe Servidor - Fim

                    //Configuração de alguns objetos da Interface do servidor
                    pbGato.Visible = true;
                    btnIniciar.Enabled = false;
                    string nomeMaquina = Dns.GetHostName();
                    IPAddress[] ip = Dns.GetHostAddresses(nomeMaquina);

                    txtLog.AppendText("Servidor Online....\r\n" +
                                      "IP do Servidor: " + ip[ip.Length-2].ToString() + "\r\n" +
                                      "Feche a janela para sair...\r\n");
                }
                else 
                {
                    //Mensagem mostrada para o usuário caso a porta TCP inserida esteja indisponível
                    MessageBox.Show("A Porta TCP " + txtTCP.Text + " está ocupada. Escolha outra porta.", 
                                    "Erro Porta TCP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex){
                MessageBox.Show("Erro de conexão : " + ex.Message);
            }
        }

        //Método que verifica todos as portas TCPs utilizados no momento pela máquina local
        private bool DisponibilidadeTCP(string tcp)
        {
            bool disponivel = true;
            IPGlobalProperties ipPropriedadesGlobais = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpPortasUtilizadas = ipPropriedadesGlobais.GetActiveTcpConnections();

            //O Array "tcpPortasUtilizadas" contem todas as portas TCP utilizadas na máquina local
            foreach (TcpConnectionInformation tcpi in tcpPortasUtilizadas) {
                //Caso alguma porta que já está sendo utilizada seja igual a porta inserida pelo usuário
                //a busca é interrompida informando que a porta está indisponível
                if (tcpi.LocalEndPoint.Port == Convert.ToInt32(tcp)) {
                    disponivel = false;
                    break;
                }
            }
            return disponivel;

        }

        //Método do evento Keypress do campo TCP que bloqueia qualquer caracter que não seja número
        private void txtTCP_KeyPress(object sender, KeyPressEventArgs e) {
            int asc = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127) {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números!");
            }
        }

    }
}
