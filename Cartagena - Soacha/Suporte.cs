using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cartagena___Soacha
{
    public class Suporte
    {
        public Jogador jogador;
        public Mao mao;
        public int jogadorID;
        string senha { get; }
        public int PartidaID;
        public string jogadorSenha;
        public Tabuleiro tabuleiro;
        public List<Image> list;
        public Form2 form;
        public bool vez = false;
        public int pecaMaisAfrente = 0;
        public int cartasNaMao;
        public string[,] cartas ;

        public Suporte(int partidaId,int jogadorID, Mao mao, Tabuleiro tabuleiro, string senha, List<Image> list, Form2 form2)
        {
            this.jogadorID = jogadorID;
            this.mao = mao;
            this.tabuleiro = tabuleiro;
            this.senha = senha;
            this.list = list;
            this.form = form2;
            this.PartidaID = partidaId;
            this.cartasNaMao = mao.nCartas;
            DefCartas();

        }

        public void Jogador(Jogador jogador)
        {
            this.jogador = jogador;
        }


        public void SelecionarPeca(int numero)
        {

        }


        public void Pular()
        {
            //
            //Botão para Pular Vez
            //
            Jogo.Jogar(jogadorID, senha);
        }

        public void Mover(int pos, string simb)
        {
            //
            //Botão para Andar para frente
            // 

            String retorno = Jogo.Jogar(jogadorID, senha, pos, simb);
            if (retorno.Contains("ERRO:"))
            {
                MessageBox.Show(retorno);
            }
            else
            {
                mao.Remontar(form, list);
                tabuleiro.AtualizarTabuleiro(PartidaID, this);
            }
        }
        public void Mover(int pos)
        {
            //
            //Botão para Andar para tras
            //
            String retorno = Jogo.Jogar(this.jogadorID, senha, pos);
            if (retorno.Contains("ERRO:"))
            {
                MessageBox.Show(retorno);
            }
            else
            {
                mao.Remontar(form, list);//remontar a mao
                tabuleiro.AtualizarTabuleiro(PartidaID, this);
            }

        }

        public void Mover()
        {
            string retorno = Jogo.Jogar(PartidaID, senha);
        }  

        public void DefCartas()
        {
            string retorno = Jogo.ConsultarMao(jogadorID, senha);
            retorno = retorno.Replace("\r", "");
            
            string[] cards = retorno.Split('\n');
            cartas = new string[cards.Length - 1,2];
            for(int i = 0; i<cards.Length-1; i++) 
            {
                string[] aux = cards[i].Split(',');
                cartas[i, 0] = aux[0];
                cartas[i, 1] = aux[1];
            }
        }

        public void DefPecas()
        {

        }
    }
}