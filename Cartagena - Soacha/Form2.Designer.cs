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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnPularVez = new System.Windows.Forms.Button();
            this.btnAndarFrente = new System.Windows.Forms.Button();
            this.btnAndarTras = new System.Windows.Forms.Button();
            this.btnTesteVez = new System.Windows.Forms.Button();
            this.lblSimb = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.tmrJogo = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(888, 688);
            this.btnPularVez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(137, 57);
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
            this.btnAndarTras.Location = new System.Drawing.Point(603, 686);
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
            // lblSimb
            // 
            this.lblSimb.AutoSize = true;
            this.lblSimb.Location = new System.Drawing.Point(695, 655);
            this.lblSimb.Name = "lblSimb";
            this.lblSimb.Size = new System.Drawing.Size(60, 16);
            this.lblSimb.TabIndex = 9;
            this.lblSimb.Text = "Simbolo:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(599, 655);
            this.lblPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(60, 16);
            this.lblPos.TabIndex = 13;
            this.lblPos.Text = "Posição:";
            this.lblPos.Click += new System.EventHandler(this.lblPos_Click);
            // 
            // tmrJogo
            // 
            this.tmrJogo.Enabled = true;
            this.tmrJogo.Interval = 10000;
            this.tmrJogo.Tick += new System.EventHandler(this.tmrJogo_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(798, 655);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 753);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblSimb);
            this.Controls.Add(this.btnTesteVez);
            this.Controls.Add(this.btnAndarTras);
            this.Controls.Add(this.btnAndarFrente);
            this.Controls.Add(this.btnPularVez);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Em Jogo - Soacha";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.Button btnAndarFrente;
        private System.Windows.Forms.Button btnAndarTras;
        private System.Windows.Forms.Button btnTesteVez;
        private System.Windows.Forms.Label lblSimb;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Timer tmrJogo;
        private System.Windows.Forms.Label lblStatus;
    }
}