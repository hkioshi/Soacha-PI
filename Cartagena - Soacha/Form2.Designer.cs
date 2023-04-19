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
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.btnAndarFrente = new System.Windows.Forms.Button();
            this.btnAndarTras = new System.Windows.Forms.Button();
            this.btnTesteVez = new System.Windows.Forms.Button();
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMao
            // 
            this.btnMao.Location = new System.Drawing.Point(12, 682);
            this.btnMao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMao.Name = "btnMao";
            this.btnMao.Size = new System.Drawing.Size(78, 68);
            this.btnMao.TabIndex = 0;
            this.btnMao.Text = "Mostrar Mão";
            this.btnMao.UseVisualStyleBackColor = true;
            this.btnMao.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstCartas
            // 
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.ItemHeight = 16;
            this.lstCartas.Location = new System.Drawing.Point(1140, 618);
            this.lstCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(161, 68);
            this.lstCartas.TabIndex = 2;
            this.lstCartas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(888, 688);
            this.btnPularVez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(137, 56);
            this.btnPularVez.TabIndex = 3;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnAndarFrente
            // 
            this.btnAndarFrente.Location = new System.Drawing.Point(745, 686);
            this.btnAndarFrente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAndarFrente.Name = "btnAndarFrente";
            this.btnAndarFrente.Size = new System.Drawing.Size(137, 60);
            this.btnAndarFrente.TabIndex = 4;
            this.btnAndarFrente.Text = "Andar Para Frente";
            this.btnAndarFrente.UseVisualStyleBackColor = true;
            this.btnAndarFrente.Click += new System.EventHandler(this.btnAndarFrente_Click);
            // 
            // btnAndarTras
            // 
            this.btnAndarTras.Location = new System.Drawing.Point(602, 686);
            this.btnAndarTras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAndarTras.Name = "btnAndarTras";
            this.btnAndarTras.Size = new System.Drawing.Size(137, 60);
            this.btnAndarTras.TabIndex = 5;
            this.btnAndarTras.Text = "Andar Para Tras";
            this.btnAndarTras.UseVisualStyleBackColor = true;
            this.btnAndarTras.Click += new System.EventHandler(this.btnAndarTras_Click);
            // 
            // btnTesteVez
            // 
            this.btnTesteVez.Location = new System.Drawing.Point(1031, 690);
            this.btnTesteVez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTesteVez.Name = "btnTesteVez";
            this.btnTesteVez.Size = new System.Drawing.Size(339, 52);
            this.btnTesteVez.TabIndex = 6;
            this.btnTesteVez.Text = "Verifacar vez (teste)";
            this.btnTesteVez.UseVisualStyleBackColor = true;
            this.btnTesteVez.Click += new System.EventHandler(this.btnTesteVez_Click);
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(663, 655);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(44, 16);
            this.lblCasa.TabIndex = 9;
            this.lblCasa.Text = "label1";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(599, 655);
            this.lblPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(57, 16);
            this.lblPos.TabIndex = 13;
            this.lblPos.Text = "Posição";
            this.lblPos.Click += new System.EventHandler(this.lblPos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 761);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.btnTesteVez);
            this.Controls.Add(this.btnAndarTras);
            this.Controls.Add(this.btnAndarFrente);
            this.Controls.Add(this.btnPularVez);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.btnMao);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Em Jogo - Soacha";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMao;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.Button btnAndarFrente;
        private System.Windows.Forms.Button btnAndarTras;
        private System.Windows.Forms.Button btnTesteVez;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblPos;
    }
}