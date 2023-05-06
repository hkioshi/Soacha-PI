using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena___Soacha
{
    public class Suporte
    {
        public Jogador Jogador;
        public Mao mao;
        public int jogadorID;
        string senha { get; }
        public int PartidaID;
        public string jogadorSenha;
        public Tabuleiro tabuleiro;
        public List<Image> list;
        public Form2 form;
        public bool vez = false;
        public Suporte( int jogadorID, string jogadorSenha, Mao mao, Tabuleiro tabuleiro, string senha, List<Image> list, Form2 form2)
        {
            this.jogadorID = jogadorID;
            this.jogadorSenha = jogadorSenha;
            this.mao = mao;
            this.tabuleiro = tabuleiro;
            this.senha = senha;
            this.list = list;
            this.form = form2;
        }

        public void jogador(Jogador jogador)
        {
            this.Jogador = jogador;
        }


        public Peca SelecionarPeca(int numero)
        {
            return Jogador.pecas[numero];
        }

        
        public void Pular()
        {
            //
            //Botão para Pular Vez
            //
            Jogo.Jogar(jogadorID, senha);
        }

        public void MoverFrente(int pos, string simb)
        {
            //
            //Botão para Andar para frente
            // 

           
            String retorno = Jogo.Jogar(this.jogadorID, senha, pos, simb);
            if (retorno.Contains("ERRO:"))
            {
                MessageBox.Show(retorno);
            }
            else
            {
                mao.Remontar(form, list);//remontar a mao
            }
            
           

        }
        private void MoverTras(int pos)
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
            }

        }






    }
}
