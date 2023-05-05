using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena___Soacha
{
    public class Suporte
    {
        Jogador Jogador;
        Mao mao;
        int jogadorID;
        string jogadorSenha;
        public Suporte( int jogadorID, string jogadorSenha, Mao mao)
        {
            this.jogadorID = jogadorID;
            this.jogadorSenha = jogadorSenha;
            this.mao = mao;
        }

        public void jogador(Jogador jogador)
        {
            this.Jogador = jogador;
        }


        public Peca SelecionarPeca(int numero)
        {
            return Jogador.pecas[numero];
        }


    }
}
