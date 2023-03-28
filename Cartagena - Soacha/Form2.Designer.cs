namespace Cartagena___Soacha
{
    partial class Form2
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
            this.btnMao = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.btnAndarFrente = new System.Windows.Forms.Button();
            this.btnAndarTras = new System.Windows.Forms.Button();
            this.btnTesteVez = new System.Windows.Forms.Button();
            this.txtFrente = new System.Windows.Forms.TextBox();
            this.txtTras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMao
            // 
            this.btnMao.Location = new System.Drawing.Point(12, 12);
            this.btnMao.Name = "btnMao";
            this.btnMao.Size = new System.Drawing.Size(215, 56);
            this.btnMao.TabIndex = 0;
            this.btnMao.Text = "Mostrar Mão";
            this.btnMao.UseVisualStyleBackColor = true;
            this.btnMao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(12, 276);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(215, 52);
            this.btnTab.TabIndex = 1;
            this.btnTab.Text = "Mostrar Tabuleiro";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.ItemHeight = 16;
            this.lstCartas.Location = new System.Drawing.Point(12, 74);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(215, 196);
            this.lstCartas.TabIndex = 2;
            this.lstCartas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(424, 38);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(474, 113);
            this.btnPularVez.TabIndex = 3;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnAndarFrente
            // 
            this.btnAndarFrente.Location = new System.Drawing.Point(424, 157);
            this.btnAndarFrente.Name = "btnAndarFrente";
            this.btnAndarFrente.Size = new System.Drawing.Size(474, 113);
            this.btnAndarFrente.TabIndex = 4;
            this.btnAndarFrente.Text = "Andar Para Frente";
            this.btnAndarFrente.UseVisualStyleBackColor = true;
            this.btnAndarFrente.Click += new System.EventHandler(this.btnAndarFrente_Click);
            // 
            // btnAndarTras
            // 
            this.btnAndarTras.Location = new System.Drawing.Point(424, 276);
            this.btnAndarTras.Name = "btnAndarTras";
            this.btnAndarTras.Size = new System.Drawing.Size(474, 113);
            this.btnAndarTras.TabIndex = 5;
            this.btnAndarTras.Text = "Andar Para Tras";
            this.btnAndarTras.UseVisualStyleBackColor = true;
            // 
            // btnTesteVez
            // 
            this.btnTesteVez.Location = new System.Drawing.Point(12, 334);
            this.btnTesteVez.Name = "btnTesteVez";
            this.btnTesteVez.Size = new System.Drawing.Size(215, 52);
            this.btnTesteVez.TabIndex = 6;
            this.btnTesteVez.Text = "Verifacar vez (teste)";
            this.btnTesteVez.UseVisualStyleBackColor = true;
            // 
            // txtFrente
            // 
            this.txtFrente.Location = new System.Drawing.Point(361, 202);
            this.txtFrente.Name = "txtFrente";
            this.txtFrente.Size = new System.Drawing.Size(35, 22);
            this.txtFrente.TabIndex = 7;
            // 
            // txtTras
            // 
            this.txtTras.Location = new System.Drawing.Point(361, 321);
            this.txtTras.Name = "txtTras";
            this.txtTras.Size = new System.Drawing.Size(35, 22);
            this.txtTras.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 491);
            this.Controls.Add(this.txtTras);
            this.Controls.Add(this.txtFrente);
            this.Controls.Add(this.btnTesteVez);
            this.Controls.Add(this.btnAndarTras);
            this.Controls.Add(this.btnAndarFrente);
            this.Controls.Add(this.btnPularVez);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnMao);
            this.Name = "Form2";
            this.Text = "Em Jogo - Soacha";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMao;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.Button btnAndarFrente;
        private System.Windows.Forms.Button btnAndarTras;
        private System.Windows.Forms.Button btnTesteVez;
        private System.Windows.Forms.TextBox txtFrente;
        private System.Windows.Forms.TextBox txtTras;
    }
}