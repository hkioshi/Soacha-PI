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
    public partial class formsSoacha : Form
    {
        public formsSoacha()
        {
            InitializeComponent();
        }
        int idPartida;
        int oi = 0;
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

        private void btnCad_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaJogador.Text);
            lblStatusJogador.Text = retorno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(oi)
            {
          
                case 0:
                    MessageBox.Show("Não aperte novamente esse Botao");
                    break;
                    case 1:
                    MessageBox.Show("To avisando, num clica denovo, senao seu computador explode");
                    break;
                    case 2:
                    MessageBox.Show("3...");
                    break;
                    case 3:
                    MessageBox.Show("2...");
                    break;
                    case 4:
                    MessageBox.Show("1...");
                    break;
                    case 5:
                    MessageBox.Show("PARABENS!!! VOCE ACHOU O EASTER EGG, SEU CABEÇA DURA");
                    break;
                    case 6:
                    oi = 0;
                    break;
            }
            oi++;

        }
    }

}
