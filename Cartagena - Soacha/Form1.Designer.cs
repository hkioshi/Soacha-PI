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
            this.lblCriacaoDePartidas = new System.Windows.Forms.Label();
            this.lblResultCriacao = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblCadPartida = new System.Windows.Forms.Label();
            this.lblStatusJogador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(12, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(194, 140);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstPartidas
            // 
            this.lstPartidas.FormattingEnabled = true;
            this.lstPartidas.ItemHeight = 16;
            this.lstPartidas.Location = new System.Drawing.Point(12, 161);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(194, 212);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.Location = new System.Drawing.Point(12, 379);
            this.btnSelecionarPartida.Name = "btnSelecionarPartida";
            this.btnSelecionarPartida.Size = new System.Drawing.Size(194, 59);
            this.btnSelecionarPartida.TabIndex = 3;
            this.btnSelecionarPartida.Text = "SelecionarPartida";
            this.btnSelecionarPartida.UseVisualStyleBackColor = true;
            this.btnSelecionarPartida.Click += new System.EventHandler(this.btnSelecionarPartida_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(212, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "a";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(582, 99);
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
            this.txtNome.Location = new System.Drawing.Point(582, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 26);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(582, 70);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 26);
            this.txtSenha.TabIndex = 7;
            // 
            // lblCriacaoDePartidas
            // 
            this.lblCriacaoDePartidas.AutoSize = true;
            this.lblCriacaoDePartidas.Location = new System.Drawing.Point(648, 9);
            this.lblCriacaoDePartidas.Name = "lblCriacaoDePartidas";
            this.lblCriacaoDePartidas.Size = new System.Drawing.Size(81, 16);
            this.lblCriacaoDePartidas.TabIndex = 9;
            this.lblCriacaoDePartidas.Text = "Criar Partida";
            this.lblCriacaoDePartidas.Click += new System.EventHandler(this.lblCriacaoDePartidas_Click);
            // 
            // lblResultCriacao
            // 
            this.lblResultCriacao.AutoSize = true;
            this.lblResultCriacao.Location = new System.Drawing.Point(599, 161);
            this.lblResultCriacao.Name = "lblResultCriacao";
            this.lblResultCriacao.Size = new System.Drawing.Size(15, 16);
            this.lblResultCriacao.TabIndex = 10;
            this.lblResultCriacao.Text = "b";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(582, 355);
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
            this.txtSenhaJogador.Location = new System.Drawing.Point(582, 317);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(208, 26);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(582, 285);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(208, 26);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // lblCadPartida
            // 
            this.lblCadPartida.AutoSize = true;
            this.lblCadPartida.Location = new System.Drawing.Point(648, 253);
            this.lblCadPartida.Name = "lblCadPartida";
            this.lblCadPartida.Size = new System.Drawing.Size(109, 16);
            this.lblCadPartida.TabIndex = 14;
            this.lblCadPartida.Text = "CadastrarPartida";
            // 
            // lblStatusJogador
            // 
            this.lblStatusJogador.AutoSize = true;
            this.lblStatusJogador.Location = new System.Drawing.Point(599, 419);
            this.lblStatusJogador.Name = "lblStatusJogador";
            this.lblStatusJogador.Size = new System.Drawing.Size(14, 16);
            this.lblStatusJogador.TabIndex = 15;
            this.lblStatusJogador.Text = "c";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblStatusJogador);
            this.Controls.Add(this.lblCadPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.lblResultCriacao);
            this.Controls.Add(this.lblCriacaoDePartidas);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelecionarPartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "formsSoacha";
            this.Text = "Soacha - Cartagena";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblCriacaoDePartidas;
        private System.Windows.Forms.Label lblResultCriacao;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblCadPartida;
        private System.Windows.Forms.Label lblStatusJogador;
        private System.Windows.Forms.Button button2;
    }
}

