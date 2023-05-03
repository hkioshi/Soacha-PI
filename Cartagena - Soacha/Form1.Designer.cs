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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsSoacha));
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstGeral = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mnuCad = new System.Windows.Forms.MenuStrip();
            this.msiCadPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMudarStatus = new System.Windows.Forms.Button();
            this.cmbTipoPartida = new System.Windows.Forms.ComboBox();
            this.mnuCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarPartidas.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.btnListarPartidas.Location = new System.Drawing.Point(886, 41);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(164, 48);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstGeral
            // 
            this.lstGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGeral.Font = new System.Drawing.Font("Monotype Corsiva", 15.2F, System.Drawing.FontStyle.Italic);
            this.lstGeral.FormattingEnabled = true;
            this.lstGeral.ItemHeight = 29;
            this.lstGeral.Location = new System.Drawing.Point(747, 94);
            this.lstGeral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstGeral.Name = "lstGeral";
            this.lstGeral.Size = new System.Drawing.Size(303, 265);
            this.lstGeral.TabIndex = 2;
            this.lstGeral.SelectedIndexChanged += new System.EventHandler(this.lstPartidas_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 49);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 40);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // mnuCad
            // 
            this.mnuCad.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCadPartida});
            this.mnuCad.Location = new System.Drawing.Point(0, 0);
            this.mnuCad.Name = "mnuCad";
            this.mnuCad.Size = new System.Drawing.Size(1062, 39);
            this.mnuCad.TabIndex = 28;
            // 
            // msiCadPartida
            // 
            this.msiCadPartida.Font = new System.Drawing.Font("Monotype Corsiva", 15.2F, System.Drawing.FontStyle.Italic);
            this.msiCadPartida.Name = "msiCadPartida";
            this.msiCadPartida.Size = new System.Drawing.Size(194, 35);
            this.msiCadPartida.Text = "Cadastrar Partida";
            this.msiCadPartida.Click += new System.EventHandler(this.zxcToolStripMenuItem_Click);
            // 
            // btnMudarStatus
            // 
            this.btnMudarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMudarStatus.Font = new System.Drawing.Font("Monotype Corsiva", 20.2F, System.Drawing.FontStyle.Italic);
            this.btnMudarStatus.Location = new System.Drawing.Point(747, 475);
            this.btnMudarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMudarStatus.Name = "btnMudarStatus";
            this.btnMudarStatus.Size = new System.Drawing.Size(303, 185);
            this.btnMudarStatus.TabIndex = 29;
            this.btnMudarStatus.Text = "Iniciar Jogo";
            this.btnMudarStatus.UseVisualStyleBackColor = true;
            this.btnMudarStatus.Visible = false;
            this.btnMudarStatus.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cmbTipoPartida
            // 
            this.cmbTipoPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoPartida.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.cmbTipoPartida.FormattingEnabled = true;
            this.cmbTipoPartida.Items.AddRange(new object[] {
            "Todas",
            "Aberta",
            "Jogando",
            "Encerrada"});
            this.cmbTipoPartida.Location = new System.Drawing.Point(747, 41);
            this.cmbTipoPartida.Name = "cmbTipoPartida";
            this.cmbTipoPartida.Size = new System.Drawing.Size(133, 48);
            this.cmbTipoPartida.TabIndex = 30;
            this.cmbTipoPartida.Text = "Todas";
            this.cmbTipoPartida.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPartida_SelectedIndexChanged);
            // 
            // formsSoacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.cmbTipoPartida);
            this.Controls.Add(this.btnMudarStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstGeral);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.mnuCad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCad;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formsSoacha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soacha - Cartagena";
            this.Load += new System.EventHandler(this.formsSoacha_Load);
            this.mnuCad.ResumeLayout(false);
            this.mnuCad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstGeral;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip mnuCad;
        private System.Windows.Forms.ToolStripMenuItem msiCadPartida;
        private System.Windows.Forms.Button btnMudarStatus;
        private System.Windows.Forms.ComboBox cmbTipoPartida;
    }
}

