using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cartagena___Soacha
{
    public partial class formsSoacha : Form
    {
        string senha; // Senha
        int idPartida; // id da partida escolhida
        int idJogador = -1; // id do jogador escolhido

     

        public formsSoacha()
        {
            InitializeComponent();
        }
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
            
        }
        
        private void btnCad_Click(object sender, EventArgs e)
        {
            //Aqui vai cadastrar o jogador e mostrar o id, o nome, a senha, e a cor
            try
            {
                string retorno = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaJogador.Text);
                string[] itens = retorno.Split(',');

                string id = itens[0];
                senha = itens[1];
                string cor = itens[2];

                lblStatusJogador.Text = $"ID: {id}, Cor: {cor}";

            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Selecione uma Partida ou Preencha os campos");
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Selecione uma Partida ou Preencha os campos");
            }

            lstJogador.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente
            string r = Jogo.ListarJogadores(idPartida);
            r = r.Replace("\r", "");

            string[] jogadores = r.Split('\n');
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogador.Items.Add(jogadores[i]);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstPartidas.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
        }
        
        private void lblResultCriacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EasterEgg (1/5)");
        }

        private void zxcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPartida o = new CadPartida();
            o.Show();
        }
        string statusPartida;

        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O botao vai pegar a partida q foi selecionada e mostrar coisas como id, nome,data de criaçao e se esta aberta
            //precisa melhorar o tratamento de erros
            try
            {
                string partidas = lstPartidas.SelectedItem.ToString();
                string[] itens = partidas.Split(new char[] { ',' });
                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = itens[1];
                string dataPartida = itens[2];
                statusPartida = itens[3];

                lblStatus.Text = $" Id: {idPartida}\n Nome: {nomePartida}\n Data: {dataPartida} \n status: {statusPartida}";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione alguma partida");
            }
            catch (FormatException)
            {
                MessageBox.Show("Selecione uma partida valida");
            }

            lstJogador.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");

            string[] jogadores = retorno.Split('\n');
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogador.Items.Add(jogadores[i]);
            }
        }

        private void lstJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string jogador = lstJogador.SelectedItem.ToString();
                string[] itens = jogador.Split(new char[] { ',' });
                idJogador = Convert.ToInt32(itens[0]);
                string nomeJogador = itens[1];
                string cor = itens[2];


                lblStatus.Text = $" Id: {idJogador}\n Nome: {nomeJogador} \n cor: {cor}";
            }
            catch
            {
                MessageBox.Show("selecione uma jogador");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Botao vai mudar o status da partida de aberta para jogando
            if (idJogador == -1 || senha == "")
            { //Aq é um mini tratamento de erro
                MessageBox.Show("selecione uma partida ou coloque um senha");
            }
            else
            {
                try
                {
                    //aq vai iniciar o outro forms
                    string id = Jogo.IniciarPartida(idJogador, senha);
                    MessageBox.Show($"{id} esta Jogando");

                    Form2 f = new Form2();
                    f.idJogador = idJogador;
                    f.senha = senha;
                    f.idPartida = idPartida;
                    f.ShowDialog();
                } 
                catch(NullReferenceException w)
                {
                    MessageBox.Show("Sem senha do Jogador");
                }
                
            }
        }
    }

}
