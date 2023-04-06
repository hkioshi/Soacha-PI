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
            this.btnListarPartidas.Location = new System.Drawing.Point(12, 39);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(220, 33);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(12, 78);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(219, 132);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(585, 219);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "a";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(5, 96);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(208, 57);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(5, 32);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(208, 26);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // lblStatusJogador
            // 
            this.lblStatusJogador.AutoSize = true;
            this.lblStatusJogador.Location = new System.Drawing.Point(12, 155);
            this.lblStatusJogador.Name = "lblStatusJogador";
            this.lblStatusJogador.Size = new System.Drawing.Size(16, 18);
            this.lblStatusJogador.TabIndex = 15;
            this.lblStatusJogador.Text = "c";
            // 
            // grpCadJogador
            // 
            this.grpCadJogador.Controls.Add(this.txtNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtSenhaJogador);
            this.grpCadJogador.Controls.Add(this.btnCad);
            this.grpCadJogador.Controls.Add(this.lblStatusJogador);
            this.grpCadJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpCadJogador.Location = new System.Drawing.Point(584, 39);
            this.grpCadJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadJogador.Name = "grpCadJogador";
            this.grpCadJogador.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadJogador.Size = new System.Drawing.Size(220, 177);
            this.grpCadJogador.TabIndex = 19;
            this.grpCadJogador.TabStop = false;
            this.grpCadJogador.Text = "Cadastrar Jogador";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(5, 64);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(208, 26);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // lstJogador
            // 
            this.lstJogador.FormattingEnabled = true;
            this.lstJogador.ItemHeight = 16;
            this.lstJogador.Location = new System.Drawing.Point(12, 215);
            this.lstJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstJogador.Name = "lstJogador";
            this.lstJogador.Size = new System.Drawing.Size(219, 148);
            this.lstJogador.TabIndex = 20;
            this.lstJogador.SelectedIndexChanged += new System.EventHandler(this.lstJogador_SelectedIndexChanged);
            // 
            // mnuCad
            // 
            this.mnuCad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCadPartida});
            this.mnuCad.Location = new System.Drawing.Point(0, 0);
            this.mnuCad.Name = "mnuCad";
            this.mnuCad.Size = new System.Drawing.Size(819, 28);
            this.mnuCad.TabIndex = 28;
            // 
            // msiCadPartida
            // 
            this.msiCadPartida.Name = "msiCadPartida";
            this.msiCadPartida.Size = new System.Drawing.Size(136, 24);
            this.msiCadPartida.Text = "Cadastrar Partida";
            this.msiCadPartida.Click += new System.EventHandler(this.zxcToolStripMenuItem_Click);
            // 
            // btnMudarStatus
            // 
            this.btnMudarStatus.Location = new System.Drawing.Point(584, 266);
            this.btnMudarStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMudarStatus.Name = "btnMudarStatus";
            this.btnMudarStatus.Size = new System.Drawing.Size(220, 124);
            this.btnMudarStatus.TabIndex = 29;
            this.btnMudarStatus.Text = "Iniciar Jogo";
            this.btnMudarStatus.UseVisualStyleBackColor = true;
            this.btnMudarStatus.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 446);
            this.Controls.Add(this.btnMudarStatus);
            this.Controls.Add(this.lstJogador);
            this.Controls.Add(this.grpCadJogador);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.mnuCad);
            this.MainMenuStrip = this.mnuCad;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.GroupBox grpCadJogador;
        private System.Windows.Forms.ListBox lstJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.MenuStrip mnuCad;
        private System.Windows.Forms.ToolStripMenuItem msiCadPartida;
        private System.Windows.Forms.Button btnMudarStatus;
    }
}

