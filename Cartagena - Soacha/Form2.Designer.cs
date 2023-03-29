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
            this.lstTab = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCasa = new System.Windows.Forms.Label();
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
            this.btnTab.Location = new System.Drawing.Point(12, 244);
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
            this.lstCartas.Size = new System.Drawing.Size(215, 164);
            this.lstCartas.TabIndex = 2;
            this.lstCartas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(587, 12);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(474, 120);
            this.btnPularVez.TabIndex = 3;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnAndarFrente
            // 
            this.btnAndarFrente.Location = new System.Drawing.Point(587, 173);
            this.btnAndarFrente.Name = "btnAndarFrente";
            this.btnAndarFrente.Size = new System.Drawing.Size(474, 156);
            this.btnAndarFrente.TabIndex = 4;
            this.btnAndarFrente.Text = "Andar Para Frente";
            this.btnAndarFrente.UseVisualStyleBackColor = true;
            this.btnAndarFrente.Click += new System.EventHandler(this.btnAndarFrente_Click);
            // 
            // btnAndarTras
            // 
            this.btnAndarTras.Location = new System.Drawing.Point(587, 366);
            this.btnAndarTras.Name = "btnAndarTras";
            this.btnAndarTras.Size = new System.Drawing.Size(474, 113);
            this.btnAndarTras.TabIndex = 5;
            this.btnAndarTras.Text = "Andar Para Tras";
            this.btnAndarTras.UseVisualStyleBackColor = true;
            this.btnAndarTras.Click += new System.EventHandler(this.btnAndarTras_Click);
            // 
            // btnTesteVez
            // 
            this.btnTesteVez.Location = new System.Drawing.Point(12, 381);
            this.btnTesteVez.Name = "btnTesteVez";
            this.btnTesteVez.Size = new System.Drawing.Size(215, 52);
            this.btnTesteVez.TabIndex = 6;
            this.btnTesteVez.Text = "Verifacar vez (teste)";
            this.btnTesteVez.UseVisualStyleBackColor = true;
            this.btnTesteVez.Click += new System.EventHandler(this.btnTesteVez_Click);
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.ItemHeight = 16;
            this.lstTab.Location = new System.Drawing.Point(233, 12);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(348, 468);
            this.lstTab.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 72);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(12, 450);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(44, 16);
            this.lblCasa.TabIndex = 9;
            this.lblCasa.Text = "label1";
            this.lblCasa.Click += new System.EventHandler(this.lblCasa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 491);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstTab);
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
        private System.Windows.Forms.ListBox lstTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCasa;
    }
}