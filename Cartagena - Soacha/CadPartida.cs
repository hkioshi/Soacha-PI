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
        formsSoacha forms;
        public CadPartida(formsSoacha forms)
        {
            InitializeComponent();
            this.forms = forms;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cria partida;
            if (txtNome.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Sem nome ou senha");
            }
            else
            {

                string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text);
                if (retorno == "ERRO: Partida já existente")
                {
                    MessageBox.Show("A partida já existe");
                }
                else
                {
                    MessageBox.Show($"Partida no id {retorno}");
                    forms.ListarPartidas();
                    this.Close();
                }

            }
        }

        private void CadPartida_Load(object sender, EventArgs e)
        {

        }
    }
}
