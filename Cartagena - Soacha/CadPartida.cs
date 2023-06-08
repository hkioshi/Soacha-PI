using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena___Soacha
{
    public partial class CadPartida : Form
    {
        public CadPartida(formsSoacha forms)
        {
            InitializeComponent();
            this.forms = forms;
        }
        formsSoacha forms;

        //
        //Cadastrar Partida
        //

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text);//Comando p/ criar partida
            if (!retorno.Contains("ERRO:"))//Detecção e tratamento de erros
            {
                MessageBox.Show($"Partida no id {retorno}");//Mensagem p/ dizer qual o id da partida jogando
                forms.ListarPartidas();
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
