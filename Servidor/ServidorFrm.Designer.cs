namespace Jokenpo {
    partial class ServidorFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServidorFrm));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtTCP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(142, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Servidor";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 41);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(397, 79);
            this.txtLog.TabIndex = 1;
            // 
            // txtTCP
            // 
            this.txtTCP.Location = new System.Drawing.Point(350, 15);
            this.txtTCP.Name = "txtTCP";
            this.txtTCP.Size = new System.Drawing.Size(57, 20);
            this.txtTCP.TabIndex = 3;
            this.txtTCP.Text = "12345";
            this.txtTCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta TCP:";
            // 
            // pbGato
            // 
            this.pbGato.Image = ((System.Drawing.Image)(resources.GetObject("pbGato.Image")));
            this.pbGato.Location = new System.Drawing.Point(12, 126);
            this.pbGato.Name = "pbGato";
            this.pbGato.Size = new System.Drawing.Size(397, 303);
            this.pbGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGato.TabIndex = 2;
            this.pbGato.TabStop = false;
            // 
            // ServidorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTCP);
            this.Controls.Add(this.pbGato);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServidorFrm";
            this.Text = "Servidor Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtTCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGato;
    }
}

