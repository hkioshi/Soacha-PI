namespace Cartagena___Soacha
{
    partial class CadPartida
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblResultCriacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(11, 31);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 23);
            this.txtNome.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(11, 57);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(157, 23);
            this.txtSenha.TabIndex = 9;
            // 
            // lblResultCriacao
            // 
            this.lblResultCriacao.AutoSize = true;
            this.lblResultCriacao.Location = new System.Drawing.Point(11, 94);
            this.lblResultCriacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultCriacao.Name = "lblResultCriacao";
            this.lblResultCriacao.Size = new System.Drawing.Size(13, 13);
            this.lblResultCriacao.TabIndex = 11;
            this.lblResultCriacao.Text = "b";
            // 
            // CadPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 194);
            this.Controls.Add(this.lblResultCriacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.button1);
            this.Name = "CadPartida";
            this.Text = "CadPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblResultCriacao;
    }
}