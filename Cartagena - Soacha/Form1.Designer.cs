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
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblStatusJogador = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.grpCadPartida = new System.Windows.Forms.GroupBox();
            this.grpCadJogador = new System.Windows.Forms.GroupBox();
            this.lstJogador = new System.Windows.Forms.ListBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.grpEntrarJogo = new System.Windows.Forms.GroupBox();
            this.btnSelecionarJogador = new System.Windows.Forms.Button();
            this.grpCadPartida.SuspendLayout();
            this.grpCadJogador.SuspendLayout();
            this.grpEntrarJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(12, 152);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(194, 196);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(212, 152);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(194, 196);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.Location = new System.Drawing.Point(212, 354);
            this.btnSelecionarPartida.Name = "btnSelecionarPartida";
            this.btnSelecionarPartida.Size = new System.Drawing.Size(194, 59);
            this.btnSelecionarPartida.TabIndex = 3;
            this.btnSelecionarPartida.Text = "Selecionar Partida";
            this.btnSelecionarPartida.UseVisualStyleBackColor = true;
            this.btnSelecionarPartida.Click += new System.EventHandler(this.btnSelecionarPartida_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 354);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "a";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(6, 88);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(208, 59);
            this.btnCriarPartida.TabIndex = 5;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(6, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 26);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(6, 53);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 26);
            this.txtSenha.TabIndex = 7;
            // 
            // lblResultCriacao
            // 
            this.lblResultCriacao.AutoSize = true;
            this.lblResultCriacao.Location = new System.Drawing.Point(12, 150);
            this.lblResultCriacao.Name = "lblResultCriacao";
            this.lblResultCriacao.Size = new System.Drawing.Size(16, 18);
            this.lblResultCriacao.TabIndex = 10;
            this.lblResultCriacao.Text = "b";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(6, 96);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(208, 56);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(6, 64);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(208, 26);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(6, 32);
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
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(212, 9);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(359, 140);
            this.btnJogar.TabIndex = 17;
            this.btnJogar.Text = "Jogar";
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
            this.grpCadPartida.Location = new System.Drawing.Point(577, 9);
            this.grpCadPartida.Name = "grpCadPartida";
            this.grpCadPartida.Size = new System.Drawing.Size(220, 172);
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
            this.grpCadJogador.Location = new System.Drawing.Point(577, 236);
            this.grpCadJogador.Name = "grpCadJogador";
            this.grpCadJogador.Size = new System.Drawing.Size(220, 177);
            this.grpCadJogador.TabIndex = 19;
            this.grpCadJogador.TabStop = false;
            this.grpCadJogador.Text = "Cadastrar Jogador";
            // 
            // lstJogador
            // 
            this.lstJogador.FormattingEnabled = true;
            this.lstJogador.ItemHeight = 16;
            this.lstJogador.Location = new System.Drawing.Point(412, 152);
            this.lstJogador.Name = "lstJogador";
            this.lstJogador.Size = new System.Drawing.Size(159, 196);
            this.lstJogador.TabIndex = 20;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaPartida.Location = new System.Drawing.Point(6, 67);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(179, 26);
            this.txtSenhaPartida.TabIndex = 21;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSenha.Location = new System.Drawing.Point(6, 44);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(135, 20);
            this.lblSenha.TabIndex = 22;
            this.lblSenha.Text = "Senha da partida";
            // 
            // grpEntrarJogo
            // 
            this.grpEntrarJogo.Controls.Add(this.txtSenhaPartida);
            this.grpEntrarJogo.Controls.Add(this.lblSenha);
            this.grpEntrarJogo.Location = new System.Drawing.Point(15, 9);
            this.grpEntrarJogo.Name = "grpEntrarJogo";
            this.grpEntrarJogo.Size = new System.Drawing.Size(191, 137);
            this.grpEntrarJogo.TabIndex = 25;
            this.grpEntrarJogo.TabStop = false;
            this.grpEntrarJogo.Text = "Entrar Jogo";
            // 
            // btnSelecionarJogador
            // 
            this.btnSelecionarJogador.Location = new System.Drawing.Point(412, 354);
            this.btnSelecionarJogador.Name = "btnSelecionarJogador";
            this.btnSelecionarJogador.Size = new System.Drawing.Size(159, 59);
            this.btnSelecionarJogador.TabIndex = 26;
            this.btnSelecionarJogador.Text = "Selecionar Jogador";
            this.btnSelecionarJogador.UseVisualStyleBackColor = true;
            this.btnSelecionarJogador.Click += new System.EventHandler(this.btnSelecionarJogador_Click);
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 442);
            this.Controls.Add(this.btnSelecionarJogador);
            this.Controls.Add(this.grpEntrarJogo);
            this.Controls.Add(this.lstJogador);
            this.Controls.Add(this.grpCadJogador);
            this.Controls.Add(this.grpCadPartida);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelecionarPartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "formsSoacha";
            this.Text = "Soacha - Cartagena";
            this.Load += new System.EventHandler(this.formsSoacha_Load);
            this.grpCadPartida.ResumeLayout(false);
            this.grpCadPartida.PerformLayout();
            this.grpCadJogador.ResumeLayout(false);
            this.grpCadJogador.PerformLayout();
            this.grpEntrarJogo.ResumeLayout(false);
            this.grpEntrarJogo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblStatusJogador;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.GroupBox grpCadPartida;
        private System.Windows.Forms.GroupBox grpCadJogador;
        private System.Windows.Forms.ListBox lstJogador;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox grpEntrarJogo;
        private System.Windows.Forms.Button btnSelecionarJogador;
    }
}

