namespace Cartagena___Soacha
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(7, 12);
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
            this.lstPartidas.Location = new System.Drawing.Point(7, 158);
            this.lstPartidas.Name = "lstPartidas";
            this.lstPartidas.Size = new System.Drawing.Size(194, 212);
            this.lstPartidas.TabIndex = 2;
            this.lstPartidas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSelecionarPartida
            // 
            this.btnSelecionarPartida.Location = new System.Drawing.Point(7, 376);
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
            this.lblStatus.Location = new System.Drawing.Point(207, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelecionarPartida);
            this.Controls.Add(this.lstPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.ListBox lstPartidas;
        private System.Windows.Forms.Button btnSelecionarPartida;
        private System.Windows.Forms.Label lblStatus;
    }
}

