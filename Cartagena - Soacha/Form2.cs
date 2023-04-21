﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
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
        public string cor { get; set; }//Variavel enviada do form principar

        //
        

        public Form2()
        {
            InitializeComponent(); 
        }
        Tabuleiro tab;
        public int pos = -1;
        string simb;
        public Peca peca = null;
        Mao mao = new Mao();


        private void Form2_Load(object sender, EventArgs e)
        {

            //
            //Aqui vai colocar as imagens em uma lista e inicar o tabuleiro
            //

            //
            //Me digam se eu devo manter isso eu colocar os paineis e so mudar as imagens dentro
            //

            string path = Directory.GetCurrentDirectory();//Colocar em Path o caminho C:\Users\2hkio\source\repos\Soacha-PI\Cartagena - Soacha\bin\Debug

            List<Image> list = new List<Image>();// Lista de imagens
                list.Add(Image.FromFile($"{path}\\imagens\\DaggerStatic.png"));// Faca
                list.Add(Image.FromFile($"{path}\\imagens\\GunStatic.png"));//Arma
                list.Add(Image.FromFile($"{path}\\imagens\\HatStatic.png"));//Chapeu
                list.Add(Image.FromFile($"{path}\\imagens\\KeyStatic.png"));//Chave
                list.Add(Image.FromFile($"{path}\\imagens\\RumStatic.png"));//Garrafa
                list.Add(Image.FromFile($"{path}\\imagens\\SkullStatic.png"));//Caveira
                list.Add(Image.FromFile($"{path}\\imagens\\Thing.png"));//Peça 1
                list.Add(Image.FromFile($"{path}\\imagens\\Thing2.png"));//Peça 2
                list.Add(Image.FromFile($"{path}\\imagens\\Thing3AndKnuckles.png"));//Peça 3
                list.Add(Image.FromFile($"{path}\\imagens\\ThingCD.png"));//Peça 4
                list.Add(Image.FromFile($"{path}\\imagens\\ThingAdventure.png"));//Peça 5

            tab = new Tabuleiro(this);//Cria tabuleiro
            tab.GerarTabuleiro(Jogo.ExibirTabuleiro(idPartida),list);//Cria o Tabuleiro
            tab.GerarPecas(Jogo.ListarJogadores(idPartida), list);//Cria as Peças
            mao.GerarCartas(Jogo.ConsultarMao(idJogador, senha), list, this);//Cria as Cartas

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
            if(pos != -1)
            {
                String retorno = Jogo.Jogar(idJogador, senha, pos, simb);
                if (retorno.Contains("ERRO:"))
                {
                    MessageBox.Show(retorno);
                }
                else
                {
                    retorno = retorno.Replace("\r", "");
                    string[] retornos = retorno.Split('\n');
                    retornos = retornos[retornos.Length - 2].Split(',');
                    int posicao = Convert.ToInt32(retornos[0]);

                    if (this.peca != null)
                    {
                        peca.Mover(cor, tab.casas, posicao, this.peca);
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma peça");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma peça");
            }
        }
        private void btnAndarTras_Click(object sender, EventArgs e)
        {
            //
            //Botão para Andar para tras
            //
            if (pos != -1|| this.peca != null)
            {
                String retorno = Jogo.Jogar(idJogador, senha, pos);
                if (retorno.Contains("ERRO:"))
                {
                    MessageBox.Show(retorno);
                }
                else
                {
                    retorno = retorno.Replace("\r", "");
                    string[] retornos = retorno.Split('\n');
                    retornos = retornos[retornos.Length - 2].Split(',');
                    int posicao = Convert.ToInt32(retornos[0]);
                   
                    peca.Mover(cor, tab.casas, posicao, this.peca);
                    MessageBox.Show("Test");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma peça");
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
            String retorno = Jogo.VerificarVez(idPartida);  
            MessageBox.Show(retorno);
        }

        private void lblPos_Click(object sender, EventArgs e)
        {
            //Segredo?? Devo Fazer mais?
            MessageBox.Show("EasterEgg (2/5)");
        }

        
        
    }
}
