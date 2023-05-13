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
        public Suporte( int jogadorID, Mao mao, Tabuleiro tabuleiro, string senha, List<Image> list, Form2 form2)
        {
            this.jogadorID = jogadorID;
            this.mao = mao;
            this.tabuleiro = tabuleiro;
            this.senha = senha;
            this.list = list;
            this.form = form2;
        }

        public void Jogador(Jogador jogador)
        {
            this.jogador = jogador;
        }


        public Peca SelecionarPeca(int numero)
        {
            return jogador.pecas[numero];
        }

        
        public void Pular()
        {
            //
            //Botão para Pular Vez
            //
            Jogo.Jogar(jogadorID, senha);
        }

        public void Mover(int pos, string simb, Peca peca)
        {
            //
            //Botão para Andar para frente
            // 

            String retorno = Jogo.Jogar(jogadorID, senha,pos, simb);
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

                if (peca != null)
                {
                    peca.Mover(jogador.cor, tabuleiro.casas, posicao);
                    mao.Remontar(form, list);
                }
                else
                {
                    MessageBox.Show("Selecione uma peça");
                }
            }
        }
        public void Mover(int pos, Peca peca)
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
                retorno = retorno.Replace("\r", "");
                string[] retornos = retorno.Split('\n');
                retornos = retornos[retornos.Length - 2].Split(',');
                int posicao = Convert.ToInt32(retornos[0]);

                peca.Mover(jogador.cor, tabuleiro.casas, posicao);
            }

        }

        public void Mover()
        {
            string retorno = Jogo.Jogar(PartidaID, senha);
        }
    }
}
