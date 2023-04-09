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

        public int idJogador { get; set; }
        public string senha { get; set; }
        public int idPartida { get; set; }

        int pos;
        String simb;

        public Form2()
        {
            InitializeComponent(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Image> list = new List<Image>();
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\DaggerStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\GunStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\HatStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\KeyStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\RumStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\SkullStatic.png"));
            Tabuleiro tab = new Tabuleiro();
            tab.GerarTabuleiro(Jogo.ExibirTabuleiro(idPartida),this,list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstCartas.Items.Clear();
            string retorno = Jogo.ConsultarMao(this.idJogador, this.senha);
            MessageBox.Show(retorno);
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length; i++)
            {
                lstCartas.Items.Add(partidas[i]);
            }
            MessageBox.Show($"{idPartida }");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partidas = lstCartas.SelectedItem.ToString();    
            string[] itens = partidas.Split(new char[] { ',' });

            simb = itens[0];
            lblCasa.Text = $"pos: {pos}, Simbolo: {simb}";
        }

      

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Jogar(idJogador, senha);
            MessageBox.Show(retorno);
        }

        private void btnAndarFrente_Click(object sender, EventArgs e)
        {
            String retorno = Jogo.Jogar(idJogador, senha, pos, simb);
            MessageBox.Show(retorno);
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                
       
      
        }

        private void lblCasa_Click(object sender, EventArgs e)
        {

        }

        private void btnAndarTras_Click(object sender, EventArgs e)
        {
            String retorno = Jogo.Jogar(idJogador, senha, pos);
            MessageBox.Show(retorno);
        }

        private void btnTesteVez_Click(object sender, EventArgs e)
        {
            String retorno = Jogo.VerificarVez(idPartida);  
            MessageBox.Show(retorno);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pos = (int)numericUpDown1.Value;
        }

        private void lblPos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EasterEgg (2/5)");
        }

        private void lstTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
