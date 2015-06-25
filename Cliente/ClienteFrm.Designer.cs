namespace Jokenpo
{
    partial class ClienteFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lbIPServidor = new System.Windows.Forms.Label();
            this.txtIPServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.slJogador1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbJogada = new System.Windows.Forms.PictureBox();
            this.rbSpock = new System.Windows.Forms.RadioButton();
            this.rbLagarto = new System.Windows.Forms.RadioButton();
            this.btnJogar = new System.Windows.Forms.Button();
            this.rbTesoura = new System.Windows.Forms.RadioButton();
            this.rbPedra = new System.Windows.Forms.RadioButton();
            this.rbPapel = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgPlacar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbJogador2 = new System.Windows.Forms.CheckBox();
            this.cbJogador1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbNomeJogador2 = new System.Windows.Forms.Label();
            this.lbNomeJogador1 = new System.Windows.Forms.Label();
            this.lbPlacarJogador2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlacarJogador1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlacar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(this.lbIPServidor);
            this.groupBox1.Controls.Add(this.txtIPServidor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autenticação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(80, 73);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(118, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Porta:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(216, 21);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(75, 20);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Text = "12345";
            // 
            // lbIPServidor
            // 
            this.lbIPServidor.AutoSize = true;
            this.lbIPServidor.Location = new System.Drawing.Point(12, 24);
            this.lbIPServidor.Name = "lbIPServidor";
            this.lbIPServidor.Size = new System.Drawing.Size(62, 13);
            this.lbIPServidor.TabIndex = 5;
            this.lbIPServidor.Text = "IP Servidor:";
            // 
            // txtIPServidor
            // 
            this.txtIPServidor.Location = new System.Drawing.Point(80, 21);
            this.txtIPServidor.Name = "txtIPServidor";
            this.txtIPServidor.Size = new System.Drawing.Size(91, 20);
            this.txtIPServidor.TabIndex = 1;
            this.txtIPServidor.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(204, 73);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(87, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(211, 20);
            this.txtNome.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusConexao,
            this.slJogador1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusConexao
            // 
            this.lblStatusConexao.Name = "lblStatusConexao";
            this.lblStatusConexao.Size = new System.Drawing.Size(277, 17);
            this.lblStatusConexao.Text = "Você precisa estar conectado ao servidor para jogar";
            // 
            // slJogador1
            // 
            this.slJogador1.Name = "slJogador1";
            this.slJogador1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbJogada);
            this.groupBox2.Controls.Add(this.rbSpock);
            this.groupBox2.Controls.Add(this.rbLagarto);
            this.groupBox2.Controls.Add(this.btnJogar);
            this.groupBox2.Controls.Add(this.rbTesoura);
            this.groupBox2.Controls.Add(this.rbPedra);
            this.groupBox2.Controls.Add(this.rbPapel);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faça a sua Jogada";
            // 
            // pbJogada
            // 
            this.pbJogada.Image = global::Jokenpo.Properties.Resources.pedra;
            this.pbJogada.Location = new System.Drawing.Point(101, 19);
            this.pbJogada.Name = "pbJogada";
            this.pbJogada.Size = new System.Drawing.Size(190, 175);
            this.pbJogada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJogada.TabIndex = 6;
            this.pbJogada.TabStop = false;
            // 
            // rbSpock
            // 
            this.rbSpock.AutoSize = true;
            this.rbSpock.Location = new System.Drawing.Point(31, 120);
            this.rbSpock.Name = "rbSpock";
            this.rbSpock.Size = new System.Drawing.Size(56, 17);
            this.rbSpock.TabIndex = 10;
            this.rbSpock.TabStop = true;
            this.rbSpock.Text = "Spock";
            this.rbSpock.UseVisualStyleBackColor = true;
            this.rbSpock.CheckedChanged += new System.EventHandler(this.rbSpock_CheckedChanged);
            // 
            // rbLagarto
            // 
            this.rbLagarto.AutoSize = true;
            this.rbLagarto.Location = new System.Drawing.Point(31, 97);
            this.rbLagarto.Name = "rbLagarto";
            this.rbLagarto.Size = new System.Drawing.Size(61, 17);
            this.rbLagarto.TabIndex = 9;
            this.rbLagarto.TabStop = true;
            this.rbLagarto.Text = "Lagarto";
            this.rbLagarto.UseVisualStyleBackColor = true;
            this.rbLagarto.CheckedChanged += new System.EventHandler(this.rbLagarto_CheckedChanged);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(216, 200);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 11;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // rbTesoura
            // 
            this.rbTesoura.AutoSize = true;
            this.rbTesoura.Location = new System.Drawing.Point(31, 74);
            this.rbTesoura.Name = "rbTesoura";
            this.rbTesoura.Size = new System.Drawing.Size(64, 17);
            this.rbTesoura.TabIndex = 8;
            this.rbTesoura.TabStop = true;
            this.rbTesoura.Tag = "3";
            this.rbTesoura.Text = "Tesoura";
            this.rbTesoura.UseVisualStyleBackColor = true;
            this.rbTesoura.CheckedChanged += new System.EventHandler(this.rbTesoura_CheckedChanged);
            // 
            // rbPedra
            // 
            this.rbPedra.AutoSize = true;
            this.rbPedra.Checked = true;
            this.rbPedra.Location = new System.Drawing.Point(31, 29);
            this.rbPedra.Name = "rbPedra";
            this.rbPedra.Size = new System.Drawing.Size(53, 17);
            this.rbPedra.TabIndex = 6;
            this.rbPedra.TabStop = true;
            this.rbPedra.Tag = "1";
            this.rbPedra.Text = "Pedra";
            this.rbPedra.UseVisualStyleBackColor = true;
            this.rbPedra.CheckedChanged += new System.EventHandler(this.rbPedra_CheckedChanged);
            // 
            // rbPapel
            // 
            this.rbPapel.AutoSize = true;
            this.rbPapel.Location = new System.Drawing.Point(31, 52);
            this.rbPapel.Name = "rbPapel";
            this.rbPapel.Size = new System.Drawing.Size(52, 17);
            this.rbPapel.TabIndex = 7;
            this.rbPapel.TabStop = true;
            this.rbPapel.Tag = "2";
            this.rbPapel.Text = "Papel";
            this.rbPapel.UseVisualStyleBackColor = true;
            this.rbPapel.CheckedChanged += new System.EventHandler(this.rbPapel_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgPlacar
            // 
            this.dgPlacar.AllowUserToAddRows = false;
            this.dgPlacar.AllowUserToDeleteRows = false;
            this.dgPlacar.AllowUserToResizeRows = false;
            this.dgPlacar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlacar.Location = new System.Drawing.Point(323, 132);
            this.dgPlacar.Name = "dgPlacar";
            this.dgPlacar.Size = new System.Drawing.Size(414, 229);
            this.dgPlacar.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbJogador2);
            this.groupBox3.Controls.Add(this.cbJogador1);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jogadores Online";
            // 
            // cbJogador2
            // 
            this.cbJogador2.AutoSize = true;
            this.cbJogador2.Enabled = false;
            this.cbJogador2.Location = new System.Drawing.Point(98, 19);
            this.cbJogador2.Name = "cbJogador2";
            this.cbJogador2.Size = new System.Drawing.Size(73, 17);
            this.cbJogador2.TabIndex = 1;
            this.cbJogador2.Text = "Jogador 2";
            this.cbJogador2.UseVisualStyleBackColor = true;
            // 
            // cbJogador1
            // 
            this.cbJogador1.AutoSize = true;
            this.cbJogador1.Enabled = false;
            this.cbJogador1.Location = new System.Drawing.Point(19, 19);
            this.cbJogador1.Name = "cbJogador1";
            this.cbJogador1.Size = new System.Drawing.Size(73, 17);
            this.cbJogador1.TabIndex = 0;
            this.cbJogador1.Text = "Jogador 1";
            this.cbJogador1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbNomeJogador2);
            this.groupBox4.Controls.Add(this.lbNomeJogador1);
            this.groupBox4.Controls.Add(this.lbPlacarJogador2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lbPlacarJogador1);
            this.groupBox4.Location = new System.Drawing.Point(325, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 50);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Placar";
            // 
            // lbNomeJogador2
            // 
            this.lbNomeJogador2.AutoSize = true;
            this.lbNomeJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeJogador2.Location = new System.Drawing.Point(303, 23);
            this.lbNomeJogador2.Name = "lbNomeJogador2";
            this.lbNomeJogador2.Size = new System.Drawing.Size(71, 13);
            this.lbNomeJogador2.TabIndex = 4;
            this.lbNomeJogador2.Text = "Jogador #2";
            // 
            // lbNomeJogador1
            // 
            this.lbNomeJogador1.AutoSize = true;
            this.lbNomeJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeJogador1.Location = new System.Drawing.Point(43, 23);
            this.lbNomeJogador1.Name = "lbNomeJogador1";
            this.lbNomeJogador1.Size = new System.Drawing.Size(71, 13);
            this.lbNomeJogador1.TabIndex = 3;
            this.lbNomeJogador1.Text = "Jogador #1";
            // 
            // lbPlacarJogador2
            // 
            this.lbPlacarJogador2.AutoSize = true;
            this.lbPlacarJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlacarJogador2.ForeColor = System.Drawing.Color.Red;
            this.lbPlacarJogador2.Location = new System.Drawing.Point(244, 11);
            this.lbPlacarJogador2.Name = "lbPlacarJogador2";
            this.lbPlacarJogador2.Size = new System.Drawing.Size(29, 31);
            this.lbPlacarJogador2.TabIndex = 2;
            this.lbPlacarJogador2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // lbPlacarJogador1
            // 
            this.lbPlacarJogador1.AutoSize = true;
            this.lbPlacarJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlacarJogador1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPlacarJogador1.Location = new System.Drawing.Point(147, 11);
            this.lbPlacarJogador1.Name = "lbPlacarJogador1";
            this.lbPlacarJogador1.Size = new System.Drawing.Size(29, 31);
            this.lbPlacarJogador1.TabIndex = 0;
            this.lbPlacarJogador1.Text = "0";
            // 
            // ClienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 446);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgPlacar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClienteFrm";
            this.Text = "Cliente Jokenpo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClienteFrm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlacar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusConexao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTesoura;
        private System.Windows.Forms.RadioButton rbPedra;
        private System.Windows.Forms.RadioButton rbPapel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.DataGridView dgPlacar;
        private System.Windows.Forms.ToolStripStatusLabel slJogador1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbJogador2;
        private System.Windows.Forms.CheckBox cbJogador1;
        private System.Windows.Forms.PictureBox pbJogada;
        private System.Windows.Forms.RadioButton rbSpock;
        private System.Windows.Forms.RadioButton rbLagarto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbNomeJogador2;
        private System.Windows.Forms.Label lbNomeJogador1;
        private System.Windows.Forms.Label lbPlacarJogador2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlacarJogador1;
        private System.Windows.Forms.Label lbIPServidor;
        private System.Windows.Forms.TextBox txtIPServidor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
    }
}

