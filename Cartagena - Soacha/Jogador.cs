using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena___Soacha
{
    public class Jogador
    {
        public string nome;
        public string id;
        public string cor;

        public Jogador(string id, string nome, string cor)
        {
            this.nome = nome;
            this.id = id;
            this.cor = cor;
        }


    }
}