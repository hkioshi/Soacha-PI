using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena___Soacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int idPartida;
        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            


            retorno = retorno.Replace("\r", "");


            string[] partidas = retorno.Split('\n');
            for(int i = 0;i < partidas.Length ;i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelecionarPartida_Click(object sender, EventArgs e)
        {
            string partidas = lstPartidas.SelectedItem.ToString();
            string[] itens = partidas.Split(new char[] {',' });

            idPartida = Convert.ToInt32(itens[0]);
            string nomePartida = itens[1];
            string dataPartida = itens[2];
            string status = itens[3];

            lblStatus.Text = $" Id: {idPartida}\n Nome: {nomePartida} \n status: {status}";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if(txtNome.Text== null || txtSenha == null)
            {
                MessageBox.Show("Sem nome ou senha");
            }
            else
            {
                string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text);
                lblResultCriacao.Text = $"Sua partida foi criada com id {retorno}";
            }
            
        }

        private void lblCriacaoDePartidas_Click(object sender, EventArgs e)
        {

        }
    }
}
