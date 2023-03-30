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
            this.lblCasa = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblPos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMao
            // 
            this.btnMao.Location = new System.Drawing.Point(9, 10);
            this.btnMao.Margin = new System.Windows.Forms.Padding(2);
            this.btnMao.Name = "btnMao";
            this.btnMao.Size = new System.Drawing.Size(161, 46);
            this.btnMao.TabIndex = 0;
            this.btnMao.Text = "Mostrar Mão";
            this.btnMao.UseVisualStyleBackColor = true;
            this.btnMao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(9, 198);
            this.btnTab.Margin = new System.Windows.Forms.Padding(2);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(161, 42);
            this.btnTab.TabIndex = 1;
            this.btnTab.Text = "Mostrar Tabuleiro";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(9, 60);
            this.lstCartas.Margin = new System.Windows.Forms.Padding(2);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(162, 134);
            this.lstCartas.TabIndex = 2;
            this.lstCartas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(440, 10);
            this.btnPularVez.Margin = new System.Windows.Forms.Padding(2);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(356, 98);
            this.btnPularVez.TabIndex = 3;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnAndarFrente
            // 
            this.btnAndarFrente.Location = new System.Drawing.Point(440, 141);
            this.btnAndarFrente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndarFrente.Name = "btnAndarFrente";
            this.btnAndarFrente.Size = new System.Drawing.Size(356, 127);
            this.btnAndarFrente.TabIndex = 4;
            this.btnAndarFrente.Text = "Andar Para Frente";
            this.btnAndarFrente.UseVisualStyleBackColor = true;
            this.btnAndarFrente.Click += new System.EventHandler(this.btnAndarFrente_Click);
            // 
            // btnAndarTras
            // 
            this.btnAndarTras.Location = new System.Drawing.Point(440, 297);
            this.btnAndarTras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAndarTras.Name = "btnAndarTras";
            this.btnAndarTras.Size = new System.Drawing.Size(356, 92);
            this.btnAndarTras.TabIndex = 5;
            this.btnAndarTras.Text = "Andar Para Tras";
            this.btnAndarTras.UseVisualStyleBackColor = true;
            this.btnAndarTras.Click += new System.EventHandler(this.btnAndarTras_Click);
            // 
            // btnTesteVez
            // 
            this.btnTesteVez.Location = new System.Drawing.Point(9, 297);
            this.btnTesteVez.Margin = new System.Windows.Forms.Padding(2);
            this.btnTesteVez.Name = "btnTesteVez";
            this.btnTesteVez.Size = new System.Drawing.Size(161, 42);
            this.btnTesteVez.TabIndex = 6;
            this.btnTesteVez.Text = "Verifacar vez (teste)";
            this.btnTesteVez.UseVisualStyleBackColor = true;
            this.btnTesteVez.Click += new System.EventHandler(this.btnTesteVez_Click);
            // 
            // lstTab
            // 
            this.lstTab.FormattingEnabled = true;
            this.lstTab.Location = new System.Drawing.Point(175, 10);
            this.lstTab.Margin = new System.Windows.Forms.Padding(2);
            this.lstTab.Name = "lstTab";
            this.lstTab.Size = new System.Drawing.Size(262, 381);
            this.lstTab.TabIndex = 7;
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(9, 366);
            this.lblCasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(35, 13);
            this.lblCasa.TabIndex = 9;
            this.lblCasa.Text = "label1";
            this.lblCasa.Click += new System.EventHandler(this.lblCasa_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 254);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(12, 256);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(45, 13);
            this.lblPos.TabIndex = 13;
            this.lblPos.Text = "Posição";
            this.lblPos.Click += new System.EventHandler(this.lblPos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 399);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.lstTab);
            this.Controls.Add(this.btnTesteVez);
            this.Controls.Add(this.btnAndarTras);
            this.Controls.Add(this.btnAndarFrente);
            this.Controls.Add(this.btnPularVez);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnMao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Em Jogo - Soacha";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPos;
    }
}