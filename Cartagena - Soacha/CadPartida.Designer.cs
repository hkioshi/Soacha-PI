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
            this.lblResultCriacao = new System.Windows.Forms.Label();
            this.btnCadPart = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultCriacao
            // 
            this.lblResultCriacao.AutoSize = true;
            this.lblResultCriacao.Location = new System.Drawing.Point(27, 122);
            this.lblResultCriacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultCriacao.Name = "lblResultCriacao";
            this.lblResultCriacao.Size = new System.Drawing.Size(13, 13);
            this.lblResultCriacao.TabIndex = 11;
            this.lblResultCriacao.Text = "b";
            // 
            // btnCadPart
            // 
            this.btnCadPart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadPart.Location = new System.Drawing.Point(14, 138);
            this.btnCadPart.Name = "btnCadPart";
            this.btnCadPart.Size = new System.Drawing.Size(202, 44);
            this.btnCadPart.TabIndex = 0;
            this.btnCadPart.Text = "Cadastrar Partida";
            this.btnCadPart.UseVisualStyleBackColor = true;
            this.btnCadPart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenha.Location = new System.Drawing.Point(48, 86);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(157, 23);
            this.txtSenha.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(30, 23);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 23);
            this.txtNome.TabIndex = 8;
            // 
            // CadPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 194);
            this.Controls.Add(this.lblResultCriacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCadPart);
            this.Name = "CadPartida";
            this.Text = "CadPartida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultCriacao;
        private System.Windows.Forms.Button btnCadPart;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
    }
}