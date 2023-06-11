namespace Cartagena___Soacha
{
    partial class CadJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadJogador));
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(12, 38);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(174, 26);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(12, 127);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(174, 26);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // btnCad
            // 
            this.btnCad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCad.BackgroundImage")));
            this.btnCad.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(208, 9);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(215, 144);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome Do Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha do Jogador";
            // 
            // CadJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(435, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadJogador";
            this.Text = "CadJogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}