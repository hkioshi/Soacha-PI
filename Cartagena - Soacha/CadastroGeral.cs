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
        bool ligado = true;
        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            //
            // LISTAR PARTIDAS
            //
            ListarPartidas();
            btnEntrar.Visible = false;//Desaparece com o botão entrar
        }  
        private void lstPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vai Colocar em variaveis: id, nome,data de criaçao e se esta aberta 
            //alem disso ja abre mostra os jogadores da partida

            //
            // !ARRUMAR O TRATAMENTO DE ERROS!
            // 
            if(ligado)
            {
                try
                {
                    //Aqui vai colocar em variaveis: id, nome,data de criaçao e se esta aberta
                    string partidas = lstGeral.SelectedItem.ToString();
                    string[] itens = partidas.Split(new char[] { ',' });
                    idPartida = Convert.ToInt32(itens[0]);
                    string nomePartida = itens[1];
                    string dataPartida = itens[2];
                    statusPartida = itens[3];

                    if(statusPartida == "A")
                    {
                        CadJogador f = new CadJogador(this);
                        f.idPartida = idPartida;
                        f.ShowDialog();
                    }
                    lblStatus.Text = $" Id: {idPartida}\n Nome: {nomePartida}\n Data: {dataPartida} \n status: {statusPartida}";
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Selecione uma partida valida");
                    ListarPartidas();
                }
                catch (Exception ex)//Esse tratamento deve ser consertado
                {
                    MessageBox.Show("Erro: "+ ex);
                    ListarPartidas();
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
                ligado = false;
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
            string retorno1 = Jogo.IniciarPartida(idJogador, senha);//iniciar partida
            if (!retorno1.Contains("ERRO:"))
            {
                string id = Jogo.IniciarPartida(idJogador, senha);//iniciar partida

                string retorno = Jogo.ListarJogadores(idPartida);//Atualiza lista de partidas
                btnEntrar.Visible = true;
                statusPartida = "J";
            }
            else
            {
                //se der erro, vem pra cá
                string substr = retorno1.Substring(5);
                MessageBox.Show(substr);
            }
        }

        private void formsSoacha_Load(object sender, EventArgs e)
        {
            
        }

        //
        //Retorno do Cadastrar Jogador
        //
        public void Retorno()
        {
            lblStatus.Text = $"ID: {idJogador}\nCor: {cor}";
            if (statusPartida == "A")
            {
                btnMudarStatus.Visible = true;
                btnEntrar.Visible = false;
            }
            else if (statusPartida == "J" && senha != "")  
            {
                btnEntrar.Visible = true;
                btnMudarStatus.Visible = false;
            }
            
        }
        public void ListarPartidas()
        {
            string retorno;
            string[] partidas;
            switch(cmbTipoPartida.Text)
            {
                case "Todas":
                    //Apagar lista
                    lstGeral.Items.Clear();

                    //Lista todas as Partidas e coloca na lista lstGeral
                    retorno = Jogo.ListarPartidas("T");
                    retorno = retorno.Replace("\r", "");

                    partidas = retorno.Split('\n');
                    for (int i = 0; i < partidas.Length; i++)
                    {
                        lstGeral.Items.Add(partidas[i]);
                    }
                    break;
                case "Aberta":
                    //Listar Partidas Abertas
                    lstGeral.Items.Clear();

                    //Lista todas as Partidas ABERTAS e coloca na lista lstGeral
                    retorno = Jogo.ListarPartidas("A");
                    retorno = retorno.Replace("\r", "");

                    partidas = retorno.Split('\n');
                    for (int i = 0; i < partidas.Length; i++)
                    {
                        lstGeral.Items.Add(partidas[i]);
                    }
                    break;
                case "Jogando":
                    //Listar Partidas Jogando
                    lstGeral.Items.Clear();

                    //Lista todas as Partidas EM JOGO e coloca na lista lstGeral
                    retorno = Jogo.ListarPartidas("J");
                    retorno = retorno.Replace("\r", "");

                    partidas = retorno.Split('\n');
                    for (int i = 0; i < partidas.Length; i++)
                    {
                        lstGeral.Items.Add(partidas[i]);
                    }
                    break;
                case "Encerrada":
                    //Listar Partidas Encerradas
                lstGeral.Items.Clear();
                //Encerrada
                //Lista todas as Partidas ENCERRADAS e coloca na lista lstGeral
                retorno = Jogo.ListarPartidas("E");
                retorno = retorno.Replace("\r", "");

                partidas = retorno.Split('\n');
                for (int i = 0; i < partidas.Length; i++)
                {
                    lstGeral.Items.Add(partidas[i]);
                }
                    break;
            }
            ligado = true;
            btnMudarStatus.Visible = false;
        }
        private void cmbTipoPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarPartidas();
        }
        private void lblStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EasterEgg(1/5)");
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (senha != null && idJogador != 0 && statusPartida == "J")

            {
                //Abrir forms
                Form2 f = new Form2();
                f.idJogador = idJogador;
                f.senha = senha;
                f.idPartida = idPartida;
                f.cor = cor;
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sem senha nem Jogador Selecionado");
            }
        }
        private void lblCreditos_Click(object sender, EventArgs e)
        {
            llblArtista.Text = "Artista: Special Annon";
        }
    }
}
