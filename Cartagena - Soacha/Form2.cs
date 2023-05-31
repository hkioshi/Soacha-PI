

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
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
        public int pos = 0;//posição do tabuleiro
        public string simb;//Simbolo
        public Peca peca = null;//peça selecionada
        Mao mao = new Mao();//estancia a mao
        List<Image> list = new List<Image>();// Lista de imagens
        public List<Image> listP = new List<Image>();
        Suporte suporte;
        Inteligencia inteligencia;



        private void Form2_Load(object sender, EventArgs e)
        {

            //
            //Aqui vai colocar as imagens em uma lista e inicar o tabuleiro
            //
            WindowState = FormWindowState.Maximized;

            string path = Directory.GetCurrentDirectory();//Colocar em Path o caminho C:\Users\2hkio\source\repos\Soacha-PI\Cartagena - Soacha\bin\Debug


            list.Add(Image.FromFile($"{path}\\imagens\\DaggerStatic.png"));// Faca
            list.Add(Image.FromFile($"{path}\\imagens\\GunStatic.png"));//Arma
            list.Add(Image.FromFile($"{path}\\imagens\\HatStatic.png"));//Chapeu
            list.Add(Image.FromFile($"{path}\\imagens\\KeyStatic.png"));//Chave
            list.Add(Image.FromFile($"{path}\\imagens\\RumStatic.png"));//Garrafa
            list.Add(Image.FromFile($"{path}\\imagens\\SkullStatic.png"));//Caveira

            listP.Add(Image.FromFile($"{path}\\pecas\\PAR1.png"));//Peça 1A
            listP.Add(Image.FromFile($"{path}\\pecas\\PAR2.png"));//Peça 1B
            listP.Add(Image.FromFile($"{path}\\pecas\\PAR3.png"));//Peça 1C
            listP.Add(Image.FromFile($"{path}\\pecas\\PBR1.png"));//Peça 2A
            listP.Add(Image.FromFile($"{path}\\pecas\\PBR2.png"));//Peça 2B
            listP.Add(Image.FromFile($"{path}\\pecas\\PBR3.png"));//Peça 2C
            listP.Add(Image.FromFile($"{path}\\pecas\\PCR1.png"));//Peça 3A
            listP.Add(Image.FromFile($"{path}\\pecas\\PCR2.png"));//Peça 3B
            listP.Add(Image.FromFile($"{path}\\pecas\\PCR3.png"));//Peça 3C
            listP.Add(Image.FromFile($"{path}\\pecas\\PDR1.png"));//Peça 4A
            listP.Add(Image.FromFile($"{path}\\pecas\\PDR2.png"));//Peça 4B
            listP.Add(Image.FromFile($"{path}\\pecas\\PDR3.png"));//Peça 4C
            listP.Add(Image.FromFile($"{path}\\pecas\\PER1.png"));//Peça 5A  
            listP.Add(Image.FromFile($"{path}\\pecas\\PER2.png"));//Peça 5B
            listP.Add(Image.FromFile($"{path}\\pecas\\PER3.png"));//Peça 5C  


            tab = new Tabuleiro(this);//Cria tabuleiro
            tab.ListarJogadores(idPartida);//Cria Jogadores
            tab.GerarTabuleiro(Jogo.ExibirTabuleiro(idPartida), list);//Cria o Tabuleiro
             mao.GerarCartas(Jogo.ConsultarMao(idJogador, senha), list, this);//Cria as Cartas 
            suporte = new Suporte( idPartida,idJogador, mao, tab, senha, list, this);
            tab.GerarPecas(listP, idJogador, suporte);//Cria as Peças
            inteligencia = new Inteligencia(suporte);
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            //
            //Botão para Pular Vez
            //
            suporte.Mover();
        }

        private void btnAndarFrente_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para frente
            //
            suporte.Mover(pos, simb);
            //MessageBox.Show(Jogo.Jogar(idJogador,senha,pos, simb) );
        }
        private void btnAndarTras_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para tras
            //
            suporte.Mover(pos);
            //MessageBox.Show(Jogo.Jogar(idJogador, senha, pos, simb));

        }

        private void btnTesteVez_Click(object sender, EventArgs e)
        {
            //
            //Botão ver se é a vez
            //

            //
            //Esse botao deve ser substituido por um timer e as peças no jogo
            // 
            tab.AtualizarTabuleiro(idPartida, suporte);
        }

        private void lblPos_Click(object sender, EventArgs e)
        {
            //Segredo?? Devo Fazer mais?
            MessageBox.Show("EasterEgg (2/5)");
        }



        private void tmrJogo_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = tab.VerVez(idPartida, idJogador, suporte);

            tab.AtualizarTabuleiro(idPartida, suporte);
            //MessageBox.Show(Jogo.ExibirHistorico(idPartida));
            lblPos.Text = $"Posição: {Convert.ToString(pos)}";
            lblSimb.Text = $"Simbolo: {simb}";
            inteligencia.Pensar(); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void posicao(int p)
        {
            lblPos.Text = $"Posição: {Convert.ToString(pos)}";
        }

        public void simbolo(string s)
        {
            lblSimb.Text = $"Simbolo: {simb}";
        }

        public void End()
        {

            tmrJogo.Stop();
            MessageBox.Show("Fim De jogo");
            this.Close();
        }
    }

}