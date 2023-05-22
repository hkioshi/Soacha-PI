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
        formsSoacha form;
        public CadJogador(formsSoacha form)
        {
            InitializeComponent();
            this.form = form;
        }
        public int idPartida;

        private void btnCad_Click(object sender, EventArgs e)
        {
            //
            // CADASTRAR JOGADOR
            //

            //
            // !ARRUMAR O TRATAMENTO DE ERROS!
            // 

            //
            // Fazer isso em outra aba igual a de cadastrar jogador
            //

            try//Teste 
            {   //Faz jogador entrar na partida e colocar 
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
                    retorno.Replace("ERRO:", "");
                }
               
                

            }
            catch (Exception ex) //Os erros devem ser descobertos e corrigidos por meio de tramento de erros
            {
                MessageBox.Show("o erro foi " + ex);
            }
        }
    }
}
