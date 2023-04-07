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
        public formsSoacha()
        {
            InitializeComponent();
        }

        string senha; // Senha
        int idPartida; // id da partida escolhida
        int idJogador ; // id do jogador escolhido

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            //
            // LISTAR PARTIDAS
            //
            lstGeral.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente

            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');
            for(int i = 0;i < partidas.Length ;i++)
            {
                lstGeral.Items.Add(partidas[i]);
            }

            
        }
        private void btnCad_Click(object sender, EventArgs e)
        {
            //
            //CADASTRAR JOGADOR
            //
            try//Teste 
            {
                string retorno = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaJogador.Text);
                string[] itens = retorno.Split(',');

                idJogador = Convert.ToInt32(itens[0]);
                senha = itens[1];
                string cor = itens[2];
                MessageBox.Show(retorno);
                lblStatus.Text = $"ID: {idJogador}\nCor: {cor}";

            }
            catch(Exception ex) 
            {
                MessageBox.Show("o erro foi "+ ex);
            }



            lstGeral.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente
            string r = Jogo.ListarJogadores(idPartida);
            r = r.Replace("\r", "");

            string[] jogadores = r.Split('\n');
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstGeral.Items.Add(jogadores[i]);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstGeral.Items.Clear(); // esse botão serve para limpar a lista antes de listar novamente
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstGeral.Items.Add(partidas[i]);
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
            //O botao vai pegar a partida q foi selecionada e mostrar coisas
            //como id, nome,data de criaçao e se esta aberta

            //precisa melhorar o tratamento de erros
            try
            {
                string partidas = lstGeral.SelectedItem.ToString();
                string[] itens = partidas.Split(new char[] { ',' });
                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = itens[1];
                string dataPartida = itens[2];
                statusPartida = itens[3];

                
                lblStatus.Text = $" Id: {idPartida}\n  Nome: {nomePartida}\n Data: {dataPartida} \n status: {statusPartida}";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione alguma partida ou Jogador valido");
            }
            catch (FormatException)
            {
                MessageBox.Show("Selecione uma partida valida");
            }

            //Aqui vai limpar e listar a lista de JOGADORES
            lstGeral.Items.Clear(); 
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');
            for (int i = 0; i < jogadores.Length; i++)
            {
                lstGeral.Items.Add(jogadores[i]);
            }
        }

        
        private void button1_Click_2(object sender, EventArgs e)
        {
            //aq vai iniciar o outro forms
            if(senha != null && idJogador != 0)
            {
                string id = Jogo.IniciarPartida(idJogador, senha);
                MessageBox.Show($"{id} esta Jogando");

                Form2 f = new Form2();
                f.idJogador = idJogador;
                f.senha = senha;
                f.idPartida = idPartida;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sem senha nem Jogador Selecionado");
            }
        }

        
    }
}
