namespace Cartagena___Soacha
{
    partial class formsSoacha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstPartidas = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblStatusJogador = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.grpCadJogador = new System.Windows.Forms.GroupBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lstJogador = new System.Windows.Forms.ListBox();
            this.mnuCad = new System.Windows.Forms.MenuStrip();
            this.msiCadPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMudarStatus = new System.Windows.Forms.Button();
            this.grpCadJogador.SuspendLayout();
            this.mnuCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(9, 32);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(165, 27);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(9, 63);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(165, 108);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(439, 178);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "a";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(4, 78);
            this.btnCad.Margin = new System.Windows.Forms.Padding(2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(156, 46);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(4, 26);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(157, 23);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // lblStatusJogador
            // 
            this.lblStatusJogador.AutoSize = true;
            this.lblStatusJogador.Location = new System.Drawing.Point(9, 126);
            this.lblStatusJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusJogador.Name = "lblStatusJogador";
            this.lblStatusJogador.Size = new System.Drawing.Size(13, 15);
            this.lblStatusJogador.TabIndex = 15;
            this.lblStatusJogador.Text = "c";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(438, 242);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(165, 114);
            this.btnJogar.TabIndex = 17;
            this.btnJogar.Text = "Entrar Jogo";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // grpCadJogador
            // 
            this.grpCadJogador.Controls.Add(this.txtNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtSenhaJogador);
            this.grpCadJogador.Controls.Add(this.btnCad);
            this.grpCadJogador.Controls.Add(this.lblStatusJogador);
            this.grpCadJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpCadJogador.Location = new System.Drawing.Point(438, 32);
            this.grpCadJogador.Margin = new System.Windows.Forms.Padding(2);
            this.grpCadJogador.Name = "grpCadJogador";
            this.grpCadJogador.Padding = new System.Windows.Forms.Padding(2);
            this.grpCadJogador.Size = new System.Drawing.Size(165, 144);
            this.grpCadJogador.TabIndex = 19;
            this.grpCadJogador.TabStop = false;
            this.grpCadJogador.Text = "Cadastrar Jogador";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(4, 52);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(157, 23);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // lstJogador
            // 
            this.lstJogador.FormattingEnabled = true;
            this.lstJogador.Location = new System.Drawing.Point(9, 175);
            this.lstJogador.Margin = new System.Windows.Forms.Padding(2);
            this.lstJogador.Name = "lstJogador";
            this.lstJogador.Size = new System.Drawing.Size(165, 121);
            this.lstJogador.TabIndex = 20;
            this.lstJogador.SelectedIndexChanged += new System.EventHandler(this.lstJogador_SelectedIndexChanged);
            // 
            // mnuCad
            // 
            this.mnuCad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCadPartida});
            this.mnuCad.Location = new System.Drawing.Point(0, 0);
            this.mnuCad.Name = "mnuCad";
            this.mnuCad.Size = new System.Drawing.Size(614, 24);
            this.mnuCad.TabIndex = 28;
            // 
            // msiCadPartida
            // 
            this.msiCadPartida.Name = "msiCadPartida";
            this.msiCadPartida.Size = new System.Drawing.Size(109, 20);
            this.msiCadPartida.Text = "Cadastrar Partida";
            this.msiCadPartida.Click += new System.EventHandler(this.zxcToolStripMenuItem_Click);
            // 
            // btnMudarStatus
            // 
            this.btnMudarStatus.Location = new System.Drawing.Point(9, 301);
            this.btnMudarStatus.Name = "btnMudarStatus";
            this.btnMudarStatus.Size = new System.Drawing.Size(165, 55);
            this.btnMudarStatus.TabIndex = 29;
            this.btnMudarStatus.Text = "Iniciar Jogo";
            this.btnMudarStatus.UseVisualStyleBackColor = true;
            this.btnMudarStatus.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.btnMudarStatus);
            this.Controls.Add(this.lstJogador);
            this.Controls.Add(this.grpCadJogador);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.mnuCad);
            this.MainMenuStrip = this.mnuCad;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formsSoacha";
            this.Text = "Soacha - Cartagena";
            this.grpCadJogador.ResumeLayout(false);
            this.grpCadJogador.PerformLayout();
            this.mnuCad.ResumeLayout(false);
            this.mnuCad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblStatusJogador;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.GroupBox grpCadJogador;
        private System.Windows.Forms.ListBox lstJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.MenuStrip mnuCad;
        private System.Windows.Forms.ToolStripMenuItem msiCadPartida;
        private System.Windows.Forms.Button btnMudarStatus;
    }
}

