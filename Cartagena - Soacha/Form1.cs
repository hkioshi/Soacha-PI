using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        int idPartida; // id da partida escolhida
        int oi = 0; // Nada Importante
        private void button1_Click(object sender, EventArgs e)
        {
            //O botao um vai listar as partidas
            lstPartidas.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');
            for(int i = 0;i < partidas.Length ;i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
        }
        private void btnSelecionarPartida_Click(object sender, EventArgs e)
        {
            //O botao vai pegar a partida q foi selecionada e mostrar coisas como id, nome,data de criaçao e se esta aberta
            try
            {
                string partidas = lstPartidas.SelectedItem.ToString();
                string[] itens = partidas.Split(new char[] { ',' });
                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = itens[1];
                string dataPartida = itens[2];
                string status = itens[3];

                lblStatus.Text = $" Id: {idPartida}\n Nome: {nomePartida}\n Data: {dataPartida} \n status: {status}";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione alguma partida");
            }
        }
        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            //Cria partida;
            if(txtNome.Text=="" || txtSenha.Text == "")
            {
                MessageBox.Show("Sem nome ou senha");
            }
            else
            {
           
                string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text);
                lblResultCriacao.Text = $"Sua partida foi criada com id {retorno}";
            }
            
        }


        private void btnCad_Click(object sender, EventArgs e)
        {
            //Aqui vai cadastrar o jogador e mostrar o id, o nome, a senha, e a cor
            //falta tratameto de erro se os campos estiverem nulos e colocar retorno em lista com variaveis
            string retorno = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaJogador.Text);
            lblStatusJogador.Text = retorno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Nada importante
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
