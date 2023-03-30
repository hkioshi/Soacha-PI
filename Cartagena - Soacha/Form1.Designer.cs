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
            this.btnSelecionarPartida = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblResultCriacao = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblStatusJogador = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.grpCadPartida = new System.Windows.Forms.GroupBox();
            this.grpCadJogador = new System.Windows.Forms.GroupBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lstJogador = new System.Windows.Forms.ListBox();
            this.btnSelecionarJogador = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.grpCadPartida.SuspendLayout();
            this.grpCadJogador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(9, 124);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(146, 159);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.Location = new System.Drawing.Point(159, 124);
            this.lstPartidas.Margin = new System.Windows.Forms.Padding(2);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(146, 160);
            this.lstPartidas.TabIndex = 2;
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.Location = new System.Drawing.Point(159, 288);
            this.btnSelecionarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarPartida.Name = "btnSelecionarPartida";
            this.btnSelecionarPartida.Size = new System.Drawing.Size(146, 48);
            this.btnSelecionarPartida.TabIndex = 3;
            this.btnSelecionarPartida.Text = "Selecionar Partida";
            this.btnSelecionarPartida.UseVisualStyleBackColor = true;
            this.btnSelecionarPartida.Click += new System.EventHandler(this.btnSelecionarPartida_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 288);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "a";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(4, 72);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(156, 48);
            this.btnCriarPartida.TabIndex = 5;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(4, 17);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 23);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(4, 43);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(157, 23);
            this.txtSenha.TabIndex = 7;
            // 
            // lblResultCriacao
            // 
            this.lblResultCriacao.AutoSize = true;
            this.lblResultCriacao.Location = new System.Drawing.Point(9, 122);
            this.lblResultCriacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultCriacao.Name = "lblResultCriacao";
            this.lblResultCriacao.Size = new System.Drawing.Size(14, 15);
            this.lblResultCriacao.TabIndex = 10;
            this.lblResultCriacao.Text = "b";
            this.lblResultCriacao.Click += new System.EventHandler(this.lblResultCriacao_Click);
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
            this.btnJogar.Location = new System.Drawing.Point(9, 7);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(417, 114);
            this.btnJogar.TabIndex = 17;
            this.btnJogar.Text = "Iniciar Jogo";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // grpCadPartida
            // 
            this.grpCadPartida.Controls.Add(this.txtNome);
            this.grpCadPartida.Controls.Add(this.txtSenha);
            this.grpCadPartida.Controls.Add(this.btnCriarPartida);
            this.grpCadPartida.Controls.Add(this.lblResultCriacao);
            this.grpCadPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpCadPartida.Location = new System.Drawing.Point(433, 7);
            this.grpCadPartida.Margin = new System.Windows.Forms.Padding(2);
            this.grpCadPartida.Name = "grpCadPartida";
            this.grpCadPartida.Padding = new System.Windows.Forms.Padding(2);
            this.grpCadPartida.Size = new System.Drawing.Size(165, 140);
            this.grpCadPartida.TabIndex = 18;
            this.grpCadPartida.TabStop = false;
            this.grpCadPartida.Text = "Cadastrar Partida";
            // 
            // grpCadJogador
            // 
            this.grpCadJogador.Controls.Add(this.txtNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtSenhaJogador);
            this.grpCadJogador.Controls.Add(this.btnCad);
            this.grpCadJogador.Controls.Add(this.lblStatusJogador);
            this.grpCadJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpCadJogador.Location = new System.Drawing.Point(433, 192);
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
            this.lstJogador.Location = new System.Drawing.Point(309, 125);
            this.lstJogador.Margin = new System.Windows.Forms.Padding(2);
            this.lstJogador.Name = "lstJogador";
            this.lstJogador.Size = new System.Drawing.Size(117, 160);
            this.lstJogador.TabIndex = 20;
            // 
            // btnSelecionarJogador
            // 
            this.btnSelecionarJogador.Location = new System.Drawing.Point(309, 288);
            this.btnSelecionarJogador.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarJogador.Name = "btnSelecionarJogador";
            this.btnSelecionarJogador.Size = new System.Drawing.Size(119, 48);
            this.btnSelecionarJogador.TabIndex = 26;
            this.btnSelecionarJogador.Text = "Selecionar Jogador";
            this.btnSelecionarJogador.UseVisualStyleBackColor = true;
            this.btnSelecionarJogador.Click += new System.EventHandler(this.btnSelecionarJogador_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(110, 318);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 27;
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 359);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSelecionarJogador);
            this.Controls.Add(this.lstJogador);
            this.Controls.Add(this.grpCadJogador);
            this.Controls.Add(this.grpCadPartida);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelecionarPartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formsSoacha";
            this.Text = "Soacha - Cartagena";
            this.grpCadPartida.ResumeLayout(false);
            this.grpCadPartida.PerformLayout();
            this.grpCadJogador.ResumeLayout(false);
            this.grpCadJogador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Button btnSelecionarPartida;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblResultCriacao;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblStatusJogador;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.GroupBox grpCadPartida;
        private System.Windows.Forms.GroupBox grpCadJogador;
        private System.Windows.Forms.ListBox lstJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnSelecionarJogador;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

