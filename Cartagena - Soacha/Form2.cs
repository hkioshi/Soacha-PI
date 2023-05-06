using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena___Soacha
{
    public partial class Form2 : Form
    {

        public int idJogador { get; set; }//Variavel enviada do form principar
        public string senha { get; set; }//Variavel enviada do form principar
        public int idPartida { get; set; }//Variavel enviada do form principar
        public string cor { get; set; }//Variavel enviada do form principar

        //


        public Form2()
        {
            InitializeComponent();
        }
        Tabuleiro tab;//cria tabuleiro
        public int pos = -1;//posição do tabuleiro
        public string simb;//Simbolo
        public Peca peca = null;//peça selecionada
        Mao mao = new Mao();//estancia a mao
        List<Image> list = new List<Image>();// Lista de imagens
        Suporte suporte;



        private void Form2_Load(object sender, EventArgs e)
        {

            //
            //Aqui vai colocar as imagens em uma lista e inicar o tabuleiro
            //

            string path = Directory.GetCurrentDirectory();//Colocar em Path o caminho C:\Users\2hkio\source\repos\Soacha-PI\Cartagena - Soacha\bin\Debug


            list.Add(Image.FromFile($"{path}\\imagens\\DaggerStatic.png"));// Faca
            list.Add(Image.FromFile($"{path}\\imagens\\GunStatic.png"));//Arma
            list.Add(Image.FromFile($"{path}\\imagens\\HatStatic.png"));//Chapeu
            list.Add(Image.FromFile($"{path}\\imagens\\KeyStatic.png"));//Chave
            list.Add(Image.FromFile($"{path}\\imagens\\RumStatic.png"));//Garrafa
            list.Add(Image.FromFile($"{path}\\imagens\\SkullStatic.png"));//Caveira
            list.Add(Image.FromFile($"{path}\\imagens\\Thing.png"));//Peça 1
            list.Add(Image.FromFile($"{path}\\imagens\\Thing2.png"));//Peça 2
            list.Add(Image.FromFile($"{path}\\imagens\\Thing3AndKnuckles.png"));//Peça 3
            list.Add(Image.FromFile($"{path}\\imagens\\ThingAdventure.png"));//Peça 4
            list.Add(Image.FromFile($"{path}\\imagens\\ThingCD.png"));//Peça 5              

            
            tab = new Tabuleiro(this);//Cria tabuleiro
            tab.ListarJogadores(idPartida);//Cria Jogadores
            tab.GerarTabuleiro(Jogo.ExibirTabuleiro(idPartida), list);//Cria o Tabuleiro
            
            mao.GerarCartas(Jogo.ConsultarMao(idJogador, senha), list, this);//Cria as Cartas 
            suporte = new Suporte(idJogador, senha, mao, tab, senha, list, this);
            tab.GerarPecas(list, idJogador, suporte);//Cria as Peças
            Inteligencia inteligencia = new Inteligencia(suporte);
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            //
            //Botão para Pular Vez
            //
            MessageBox.Show(Jogo.Jogar(idJogador, senha));
        }

        private void btnAndarFrente_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para frente
            // 
                
            if (pos != -1 || this.peca != null)
            {
                String retorno = Jogo.Jogar(idJogador, senha, pos, simb);
                if (retorno.Contains("ERRO:"))
                {
                    MessageBox.Show(retorno);
                }
                else
                {
                    mao.Remontar(this, list);//remontar a mao
                }
            }
            else if (pos == -1)
            {
                MessageBox.Show("Selecione uma peça");
            }
            else if (this.peca == null)
            {
                MessageBox.Show("Selecione uma Carta");
            }

        }
        private void btnAndarTras_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para tras
            //
            if (pos != -1 || this.peca != null)
            {
                String retorno = Jogo.Jogar(idJogador, senha, pos);
                if (retorno.Contains("ERRO:"))
                {
                    MessageBox.Show(retorno);
                }
                else
                {
                    mao.Remontar(this, list);//remontar a mao
                }
            }
            else if(pos == -1)
            {
                MessageBox.Show("Selecione uma peça");
            }
            else if(this.peca == null)
            {
                MessageBox.Show("Selecione uma Carta");
            }

        }

        private void btnTesteVez_Click(object sender, EventArgs e)
        {
            //
            //Botão ver se é a vez
            //

            //
            //Esse botao deve ser substituido por um timer e as peças no jogo
            // 
            tab.AtualizarTabuleiro(idPartida);
        }

        private void lblPos_Click(object sender, EventArgs e)
        {
            //Segredo?? Devo Fazer mais?
            MessageBox.Show("EasterEgg (2/5)");
        }

        //colocar no lblPos a posição
        public void DefinirPos(int pos)
        {
            lblPos.Text = $"Posição: {Convert.ToString(pos)}";
        }

        //colocar no lblSimb o Simbolo
        public void DefinirSimb(string simb)
        {
            lblSimb.Text = $"Simbolo: {simb}";
        }

        private void tmrJogo_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = tab.VerVez(idPartida,idJogador,suporte);
            tab.AtualizarTabuleiro(idPartida);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
