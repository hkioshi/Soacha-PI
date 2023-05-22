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
            this.lblSimb = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.tmrJogo = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPularVez
            // 
            this.btnPularVez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPularVez.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPularVez.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPularVez.Location = new System.Drawing.Point(1189, 556);
            this.btnPularVez.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(154, 93);
            this.btnPularVez.TabIndex = 3;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // btnAndarFrente
            // 
            this.btnAndarFrente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAndarFrente.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndarFrente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAndarFrente.Location = new System.Drawing.Point(1008, 556);
            this.btnAndarFrente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAndarFrente.Name = "btnAndarFrente";
            this.btnAndarFrente.Size = new System.Drawing.Size(173, 93);
            this.btnAndarFrente.TabIndex = 4;
            this.btnAndarFrente.Text = "Andar Para Frente";
            this.btnAndarFrente.UseVisualStyleBackColor = true;
            this.btnAndarFrente.Click += new System.EventHandler(this.btnAndarFrente_Click);
            // 
            // btnAndarTras
            // 
            this.btnAndarTras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAndarTras.BackColor = System.Drawing.Color.Transparent;
            this.btnAndarTras.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndarTras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAndarTras.Location = new System.Drawing.Point(822, 556);
            this.btnAndarTras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAndarTras.Name = "btnAndarTras";
            this.btnAndarTras.Size = new System.Drawing.Size(178, 92);
            this.btnAndarTras.TabIndex = 5;
            this.btnAndarTras.Text = "Andar Para Tras";
            this.btnAndarTras.UseVisualStyleBackColor = false;
            this.btnAndarTras.Click += new System.EventHandler(this.btnAndarTras_Click);
            // 
            // lblSimb
            // 
            this.lblSimb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSimb.AutoSize = true;
            this.lblSimb.BackColor = System.Drawing.Color.Transparent;
            this.lblSimb.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimb.ForeColor = System.Drawing.Color.Black;
            this.lblSimb.Location = new System.Drawing.Point(1020, 519);
            this.lblSimb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSimb.Name = "lblSimb";
            this.lblSimb.Size = new System.Drawing.Size(100, 34);
            this.lblSimb.TabIndex = 9;
            this.lblSimb.Text = "Simbolo:";
            // 
            // lblPos
            // 
            this.lblPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPos.AutoSize = true;
            this.lblPos.BackColor = System.Drawing.Color.Transparent;
            this.lblPos.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPos.Location = new System.Drawing.Point(825, 519);
            this.lblPos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(97, 34);
            this.lblPos.TabIndex = 13;
            this.lblPos.Text = "Posição:";
            this.lblPos.Click += new System.EventHandler(this.lblPos_Click);
            // 
            // tmrJogo
            // 
            this.tmrJogo.Enabled = true;
            this.tmrJogo.Interval = 5000;
            this.tmrJogo.Tick += new System.EventHandler(this.tmrJogo_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(609, 602);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 660);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblSimb);
            this.Controls.Add(this.btnAndarTras);
            this.Controls.Add(this.btnAndarFrente);
            this.Controls.Add(this.btnPularVez);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.Label lblSimb;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Timer tmrJogo;
        private System.Windows.Forms.Label lblStatus;
    }
}