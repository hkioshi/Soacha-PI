using CartagenaServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
        public int[] pecas;
        public int turno = 1;
        int s;
        public int pecasEmJogo = 6;
        int cont;

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


        }

        public void Jogador(Jogador jogador)
        {
            this.jogador = jogador;
        }


        public void SelecionarPeca(int numero)
        {

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
                Array.Sort(pecas);
                Atualizar(pos, Convert.ToInt32(tabuleiro.AtualizarTabuleiro(PartidaID, this)));
                if (turno < 3)
                    turno++;
                else
                    turno = 1;
                DefCartas();

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
                Array.Sort(pecas);
                Atualizar(pos,Convert.ToInt32( tabuleiro.AtualizarTabuleiro(PartidaID, this)));
                if (turno < 3)  
                    turno++;
                else
                    turno = 1;
            }

        }

        public void Mover()
        {
            string retorno = Jogo.Jogar(PartidaID, senha);
            if (turno < 3)
                turno++;
            else
                turno = 1;
          }  

        public void Atualizar(int pos, int dest)
        {
            if(dest == 37)
            {

                pecasEmJogo--;
                if(pecasEmJogo == 0)
                {
                    form.End();
                }
            }
            int i = 0;
            foreach(int s in pecas)
            {
                if (s == pos)
                {
                    pecas[i] = dest;
                    break;
                }  
                else
                    i++;
                
            }
            Array.Sort(pecas);
            i = pecas.Length -1;
            bool ok = true;
            while (ok)
            {
                if (pecas[i] != 37)
                {
                    pecaMaisAfrente = pecas.Last();
                    ok = false;
                }
                else
                {
                    var lista = pecas.ToList(); // cria um objeto do tipo List<string> a partir do vetor
                    lista.RemoveAt(i); // remove o item na posição 1
                    pecas = lista.ToArray(); // recria o vetor a partir da lista
                    i--;
                }
                if (i == -1)
                    form.End();

            }
        }
        public void DefPecas()
        {
            int total = 0;
            int copias;
            string retorno = Jogo.VerificarVez(PartidaID);
            retorno.Replace("\r", "");
            string[] aux = retorno.Split('\n');
            var lista = aux.ToList(); // cria um objeto do tipo List<string> a partir do vetor
            lista.RemoveAt(0); // remove o item na posição 1
            aux = lista.ToArray(); // recria o vetor a partir da lista
            string[] pos = aux.Where(temp => temp.Contains(Convert.ToString(jogadorID))).ToArray();
            pecas = new int[6];
            copias = pos.Length;

            while (total < 6)
            {
                for (int i = 0; i < copias; i++)
                {
                    string[] a = pos[i].Split(',');
                    for (int j = 0; j < Convert.ToInt32(a[2]); j++)
                    {
                        pecas[total] = Convert.ToInt32(a[0]);
                        total++;
                    }

                }
            }
            Array.Sort(pecas);


        }

        public void DefCartas()
        {
            string retorno = Jogo.ConsultarMao(jogadorID, senha);
            retorno = retorno.Replace("\r", "");
            
            string[] cards = retorno.Split('\n');
            s = cards.Length - 1;
            cartas = new string[cards.Length - 1,2];
            for(int i = 0; i<cards.Length-1; i++) 
            {
                string[] aux = cards[i].Split(',');
                cartas[i, 0] = aux[0];
                cartas[i, 1] = aux[1];

            }
            
            
        }

        public void Defs()
        {
            DefPecas();
            DefCartas();
        }

        public string[] CartaCmMaisCopias()
        {
            int q= 0;
            string[] sf = new string[2];
            for (int i = 0; i < s; i++)
            {
                if (Convert.ToInt32(cartas[i, 1]) > q)
                {
                    sf[0] = cartas[i, 0];
                    sf[1] = cartas[i, 1];
                    q = Convert.ToInt32(cartas[i, 1]);
                }
            }
            return sf;
        }

        public string[] CartaCmMenosCopias()
        {
            int q = 100;
            string[] sf = new string[2];
            for (int i = 0; i < s; i++)
            {
                if (Convert.ToInt32(cartas[i, 1]) < q)
                {
                    sf[0] = cartas[i, 0];
                    sf[1] = cartas[i, 1];
                    q = Convert.ToInt32(cartas[i, 1]);

                }
            }
            return sf;
        }
    }
}