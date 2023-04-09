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
    public partial class Form2 : Form
    {

        public int idJogador { get; set; }//Variavel enviada do form principar
        public string senha { get; set; }//Variavel enviada do form principar
        public int idPartida { get; set; }//Variavel enviada do form principar

        //
        int pos; 
        String simb;

        public Form2()
        {
            InitializeComponent(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //
            //Aqui vai colocar as imagens em uma lista e inicar o tabuleiro
            //

            //
            //Me digam se eu devo manter isso eu colocar os paineis e so mudar as imagens dentro
            //

            List<Image> list = new List<Image>();
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\DaggerStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\GunStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\HatStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\KeyStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\RumStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\SkullStatic.png"));
            //Cria tabuleiro
            Tabuleiro tab = new Tabuleiro();
            tab.GerarTabuleiro(Jogo.ExibirTabuleiro(idPartida),this,list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            //Aqui vai pegar as cartas na mao e colocar na listBox lstCartas
            //
            lstCartas.Items.Clear();
            string retorno = Jogo.ConsultarMao(this.idJogador, this.senha);
            MessageBox.Show(retorno);
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstCartas.Items.Add(partidas[i]);
            }
            MessageBox.Show($"{idPartida }");//Essa deve mbox deve ser deletada depois

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //Vai colocar posição e simbolo nas variaveis globais
            //
            string partidas = lstCartas.SelectedItem.ToString();    
            string[] itens = partidas.Split(new char[] { ',' });

            simb = itens[0];
            lblCasa.Text = $"pos: {pos}, Simbolo: {simb}";//Talvez essa lbl deva ser deletada depois
        }

      

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            //
            //Botão para Pular Vez
            //
            string retorno = Jogo.Jogar(idJogador, senha);
            MessageBox.Show(retorno);
        }

        private void btnAndarFrente_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para frente
            //
            String retorno = Jogo.Jogar(idJogador, senha, pos, simb);
            MessageBox.Show(retorno);
            
        }
        private void btnAndarTras_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para tras
            //
            String retorno = Jogo.Jogar(idJogador, senha, pos);
            MessageBox.Show(retorno);
        }

        private void btnTesteVez_Click(object sender, EventArgs e)
        {
            //
            //Botão ver se é a vez
            //

            //
            //Esse botao deve ser substituido por um timer e as peças no jogo
            // 
            String retorno = Jogo.VerificarVez(idPartida);  
            MessageBox.Show(retorno);
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //
            //Aqui vai colocar o valor da coisa para a variavel global da posição
            //
            pos = (int)numericUpDown1.Value;
        }

        private void lblPos_Click(object sender, EventArgs e)
        {
            //Segredo?? Devo Fazer mais?
            MessageBox.Show("EasterEgg (2/5)");
        }

        
    }
}
