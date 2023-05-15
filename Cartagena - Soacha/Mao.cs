using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena___Soacha
{
    public class Mao
    {
        public int nCartas = 0;//Numero total de cartas
        public List<Carta> cartas = new List<Carta>();
        public void GerarCartas(string retorno, List<Image> list, Form2 form)
        {
            nCartas = 0;
            retorno = retorno.Replace("\r", "");
            string[] cards = retorno.Split('\n');

            //Este for serve para definir o numero de cartas que tem na mao
            for(int i= 0; i < cards.Length -1;i++) 
            {
                string[] aux = cards[i].Split(',');
                nCartas += Convert.ToInt32(aux[1]);
            }

            int total = 0;
            for(int i = 0; i < cards.Length-1;i++) 
            {
                string[] a = cards[i].Split(',');
                string simb = a[0];

                simb = simb.Replace("\r", "");
                simb = simb.Replace("\n", "");
                int copias = Convert.ToInt32(a[1]);
                while (copias > 0)
                {
                    cartas.Add(new Carta(form, simb));
                    cartas[total].Montar(form, 20, form.Size.Height - 110, list, total);
                    copias--;
                    total++;
                }
            }
            /*string simb;
            retorno = retorno.Replace("\r", "");
            string[] cards = retorno.Split('\n');

            int i = 0, tipo = 0, copias = 0;

            for (int j = 0; j < cards.Length-1;j++)
            {
                string[] a = cards[tipo].Split(',');
                copias += Convert.ToInt32(a[1]);
                
            }

            while(i < 6) 
            {
                string[] a = cards[tipo].Split(',');
                simb = a[0];

                simb = simb.Replace("\r", "");
                simb = simb.Replace("\n", "");
                 copias = Convert.ToInt32(a[1]);
                while(copias > 0)
                {
                    cartas.Add(new Carta(form, simb));
                    cartas[i].Montar(form, 20, form.Size.Height - 110, list, i);
                    copias--;
                    i++;
                }
                tipo++;
            }*/
        }

        //
        //Desmonta e remonta a mão
        //
        public void Remontar(Form2 form, List<Image> list)
        {
            foreach(Carta carta in cartas)
            {
                carta.Desmontar(form);
            }
            cartas.Clear(); 
            GerarCartas(Jogo.ConsultarMao(form.idJogador, form.senha), list, form);

        }

    }
}
