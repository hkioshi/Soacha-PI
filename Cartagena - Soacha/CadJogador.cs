using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena___Soacha
{
    public partial class CadJogador : Form
    {
        
        public CadJogador(formsSoacha form)
        {
            InitializeComponent();
            this.form = form;
        }
        public int idPartida;
        formsSoacha form;

        private void btnCad_Click(object sender, EventArgs e)
        {
            //
            // CADASTRAR JOGADOR
            //
            //Faz jogador entrar na partida e colocar 
            string retorno = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaJogador.Text);
            if(!retorno.Contains("ERRO:"))
            {
                string[] itens = retorno.Split(',');

                form.idJogador = Convert.ToInt32(itens[0]);
                form.senha = itens[1];
                string cor = itens[2];
                cor = cor.Replace("\r", "");
                cor = cor.Replace("\n", "");
                form.cor = cor;
                    
                form.Retorno();
                this.Close();
            }
            else
            {
                //se der erro, vem pra cá
                string substr = retorno.Substring(5);
                MessageBox.Show(substr);
            }   
        }
    }
}
