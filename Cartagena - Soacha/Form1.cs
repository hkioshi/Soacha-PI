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

        public string senha; // Senha
        public int idPartida; // id da partida escolhida
        public int idJogador ; // id do jogador escolhido
        public string statusPartida; //status da partida
        public string cor;// cor do jogador


        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            //
            // LISTAR PARTIDAS
            //
            ListarPartidas();
        }  
        
        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vai Colocar em variaveis: id, nome,data de criaçao e se esta aberta 
            //alem disso ja abre mostra os jogadores da partida

            //
            // !ARRUMAR O TRATAMENTO DE ERROS!
            // 
            try
            {
                //Aqui vai colocar em variaveis: id, nome,data de criaçao e se esta aberta
                string partidas = lstGeral.SelectedItem.ToString();
                string[] itens = partidas.Split(new char[] { ',' });
                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = itens[1];
                string dataPartida = itens[2];
                statusPartida = itens[3];

                CadJogador f = new CadJogador(this);
                f.idPartida = idPartida;
                f.ShowDialog();


                lblStatus.Text = $" Id: {idPartida}\n  Nome: {nomePartida}\n Data: {dataPartida} \n status: {statusPartida}";
            }
            catch (Exception)//Esse tratamento deve ser consertado
            {
                MessageBox.Show("Selecione alguma partida ou Jogador valido");
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
        private void zxcToolStripMenuItem_Click(object sender, EventArgs e)//Essa Aq é o botão da barra de cima
        {
            //Vai abrir nova aba para cadastrar partida
            CadPartida o = new CadPartida(this);
            o.Show();
        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            //aq vai iniciar o outro forms
            if(senha != null && idJogador != 0)
            {
                string id = Jogo.IniciarPartida(idJogador, senha);//iniciar partida
                MessageBox.Show($"{id} esta Jogando"); //depois essa mbox deve ser retirada

                string retorno = Jogo.ListarJogadores(idPartida);

                //Abrir forms
                Form2 f = new Form2();
                f.idJogador = idJogador;
                f.senha = senha;
                f.idPartida = idPartida;
                f.cor = cor;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sem senha nem Jogador Selecionado");
            }
        }

        private void formsSoacha_Load(object sender, EventArgs e)
        {
            
        }

        public void Retorno()
        {
            lblStatus.Text = $"ID: {idJogador}\nCor: {cor}";
            btnMudarStatus.Visible = true;
        }

        public void ListarPartidas()
        {
            if (cmbTipoPartida.Text == "Todas")//Para todas as partidas
            {
                //Apagar lista
                lstGeral.Items.Clear();

                //Lista todas as Partidas e coloca na lista lstGeral
                string retorno = Jogo.ListarPartidas("T");
                retorno = retorno.Replace("\r", "");

                string[] partidas = retorno.Split('\n');
                for (int i = 0; i < partidas.Length; i++)
                {
                    lstGeral.Items.Add(partidas[i]);
                }
            }
            else if (cmbTipoPartida.Text == "Aberta")//Para todas as partidas abertas
            {
                //Listar Partidas Abertas
                lstGeral.Items.Clear();

                //Lista todas as Partidas ABERTAS e coloca na lista lstGeral
                string retorno = Jogo.ListarPartidas("A");
                retorno = retorno.Replace("\r", "");

                string[] partidas = retorno.Split('\n');
                for (int i = 0; i < partidas.Length; i++)
                {
                    lstGeral.Items.Add(partidas[i]);
                }
            }
            else if (cmbTipoPartida.Text == "Jogando") //Para todas as partidas EM JOGO
            {
                //Listar Partidas Jogando
                lstGeral.Items.Clear();

                //Lista todas as Partidas EM JOGO e coloca na lista lstGeral
                string retorno = Jogo.ListarPartidas("J");
                retorno = retorno.Replace("\r", "");

                string[] partidas = retorno.Split('\n');
                for (int i = 0; i < partidas.Length; i++)
                {
                    lstGeral.Items.Add(partidas[i]);
                }
            }
            else//Para todas as partidas ENCERRADAS
            {
                //Listar Partidas Encerradas
                lstGeral.Items.Clear();

                //Lista todas as Partidas ENCERRADAS e coloca na lista lstGeral
                string retorno = Jogo.ListarPartidas("E");
                retorno = retorno.Replace("\r", "");

                string[] partidas = retorno.Split('\n');
                for (int i = 0; i < partidas.Length; i++)
                {
                    lstGeral.Items.Add(partidas[i]);
                }
            }
        }
    }
}
