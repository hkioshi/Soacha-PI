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
            this.grpCadJogador = new System.Windows.Forms.GroupBox();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.lblStatusJogador = new System.Windows.Forms.Label();
            this.grpCadJogador.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadJogador
            // 
            this.grpCadJogador.Controls.Add(this.lblSenhaPartida);
            this.grpCadJogador.Controls.Add(this.lblNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtNomeJogador);
            this.grpCadJogador.Controls.Add(this.txtSenhaJogador);
            this.grpCadJogador.Controls.Add(this.btnCad);
            this.grpCadJogador.Controls.Add(this.lblStatusJogador);
            this.grpCadJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpCadJogador.Location = new System.Drawing.Point(12, 11);
            this.grpCadJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadJogador.Name = "grpCadJogador";
            this.grpCadJogador.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCadJogador.Size = new System.Drawing.Size(411, 252);
            this.grpCadJogador.TabIndex = 20;
            this.grpCadJogador.TabStop = false;
            this.grpCadJogador.Text = "Cadastrar Jogador";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSenhaPartida.Location = new System.Drawing.Point(11, 135);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(137, 20);
            this.lblSenhaPartida.TabIndex = 17;
            this.lblSenhaPartida.Text = "Senha da Partida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeJogador.Location = new System.Drawing.Point(11, 52);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(141, 20);
            this.lblNomeJogador.TabIndex = 16;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeJogador.Location = new System.Drawing.Point(10, 78);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(174, 26);
            this.txtNomeJogador.TabIndex = 12;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaJogador.Location = new System.Drawing.Point(10, 157);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(174, 26);
            this.txtSenhaJogador.TabIndex = 13;
            // 
            // btnCad
            // 
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCad.Location = new System.Drawing.Point(190, 63);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(215, 135);
            this.btnCad.TabIndex = 11;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // lblStatusJogador
            // 
            this.lblStatusJogador.AutoSize = true;
            this.lblStatusJogador.Location = new System.Drawing.Point(12, 155);
            this.lblStatusJogador.Name = "lblStatusJogador";
            this.lblStatusJogador.Size = new System.Drawing.Size(0, 18);
            this.lblStatusJogador.TabIndex = 15;
            // 
            // CadJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 274);
            this.Controls.Add(this.grpCadJogador);
            this.Name = "CadJogador";
            this.Text = "CadJogador";
            this.grpCadJogador.ResumeLayout(false);
            this.grpCadJogador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadJogador;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Label lblStatusJogador;
    }
}