﻿namespace Cartagena___Soacha
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
            this.lstGeral = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblStatusJogador = new System.Windows.Forms.Label();
            this.grpCadJogador = new System.Windows.Forms.GroupBox();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.mnuCad = new System.Windows.Forms.MenuStrip();
            this.msiCadPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMudarStatus = new System.Windows.Forms.Button();
            this.cmbTipoPartida = new System.Windows.Forms.ComboBox();
            this.grpCadJogador.SuspendLayout();
            this.mnuCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnListarPartidas.Location = new System.Drawing.Point(115, 36);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(162, 37);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstGeral
            // 
            this.lstGeral.FormattingEnabled = true;
            this.lstGeral.ItemHeight = 16;
            this.lstGeral.Location = new System.Drawing.Point(12, 77);
            this.lstGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstGeral.Name = "lstGeral";
            this.lstGeral.Size = new System.Drawing.Size(265, 180);
            this.lstGeral.TabIndex = 2;
            this.lstGeral.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(283, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "a";
            // 
            // btnCad
            // 
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCad.Location = new System.Drawing.Point(186, 19);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(137, 115);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(6, 41);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(174, 26);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // lblStatusJogador
            // 
            this.lblStatusJogador.AutoSize = true;
            this.lblStatusJogador.Location = new System.Drawing.Point(12, 155);
            this.lblStatusJogador.Name = "lblStatusJogador";
            this.lblStatusJogador.Size = new System.Drawing.Size(0, 18);
            this.lblStatusJogador.TabIndex = 15;
            // 
            // grpCadJogador
            // 
            this.grpCadJogador.Controls.Add(this.lblSenhaPartida);
            this.grpCadJogador.Controls.Add(this.lblNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtSenhaJogador);
            this.grpCadJogador.Controls.Add(this.btnCad);
            this.grpCadJogador.Controls.Add(this.lblStatusJogador);
            this.grpCadJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpCadJogador.Location = new System.Drawing.Point(568, 36);
            this.grpCadJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadJogador.Name = "grpCadJogador";
            this.grpCadJogador.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadJogador.Size = new System.Drawing.Size(339, 140);
            this.grpCadJogador.TabIndex = 19;
            this.grpCadJogador.TabStop = false;
            this.grpCadJogador.Text = "Cadastrar Jogador";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSenhaPartida.Location = new System.Drawing.Point(6, 74);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(137, 20);
            this.lblSenhaPartida.TabIndex = 17;
            this.lblSenhaPartida.Text = "Senha da Partida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeJogador.Location = new System.Drawing.Point(6, 19);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(141, 20);
            this.lblNomeJogador.TabIndex = 16;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(6, 96);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(174, 26);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // mnuCad
            // 
            this.mnuCad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCadPartida});
            this.mnuCad.Location = new System.Drawing.Point(0, 0);
            this.mnuCad.Name = "mnuCad";
            this.mnuCad.Size = new System.Drawing.Size(938, 31);
            this.mnuCad.TabIndex = 28;
            // 
            // msiCadPartida
            // 
            this.msiCadPartida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.msiCadPartida.Name = "msiCadPartida";
            this.msiCadPartida.Size = new System.Drawing.Size(155, 27);
            this.msiCadPartida.Text = "Cadastrar Partida";
            this.msiCadPartida.Click += new System.EventHandler(this.zxcToolStripMenuItem_Click);
            // 
            // btnMudarStatus
            // 
            this.btnMudarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnMudarStatus.Location = new System.Drawing.Point(568, 197);
            this.btnMudarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMudarStatus.Name = "btnMudarStatus";
            this.btnMudarStatus.Size = new System.Drawing.Size(339, 60);
            this.btnMudarStatus.TabIndex = 29;
            this.btnMudarStatus.Text = "Iniciar Jogo";
            this.btnMudarStatus.UseVisualStyleBackColor = true;
            this.btnMudarStatus.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cmbTipoPartida
            // 
            this.cmbTipoPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTipoPartida.FormattingEnabled = true;
            this.cmbTipoPartida.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cmbTipoPartida.Location = new System.Drawing.Point(12, 36);
            this.cmbTipoPartida.Name = "cmbTipoPartida";
            this.cmbTipoPartida.Size = new System.Drawing.Size(97, 33);
            this.cmbTipoPartida.TabIndex = 30;
            this.cmbTipoPartida.Text = "Todas";
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 475);
            this.Controls.Add(this.cmbTipoPartida);
            this.Controls.Add(this.btnMudarStatus);
            this.Controls.Add(this.grpCadJogador);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstGeral);
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
        private System.Windows.Forms.ListBox lstGeral;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblStatusJogador;
        private System.Windows.Forms.GroupBox grpCadJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.MenuStrip mnuCad;
        private System.Windows.Forms.ToolStripMenuItem msiCadPartida;
        private System.Windows.Forms.Button btnMudarStatus;
        private System.Windows.Forms.ComboBox cmbTipoPartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeJogador;
    }
}

