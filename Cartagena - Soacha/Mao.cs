using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena___Soacha
{
    public class Mao
    {
        public int nCartas = 6;
        public List<Carta> cartas = new List<Carta>();
        public void GerarCartas(string retorno, List<Image> list, Form2 form)
        {
            string simb;
            retorno = retorno.Replace("\r", "");
            string[] cards = retorno.Split('\n');
            int i = 0, tipo = 0;
            while(i < 6) 
            {
                string[] a = cards[tipo].Split(',');
                simb = a[0];

                simb = simb.Replace("\r", "");
                simb = simb.Replace("\n", "");
                int copias = Convert.ToInt32(a[1]);
                while(copias > 0)
                {
                    cartas.Add(new Carta(form, simb));
                    cartas[i].Montar(form, 20, 0, list, i);
                    copias--;
                    i++;
                }
                tipo++;
            }



            /*for(int i = 0; i < cards.Length - 1; i++)
            {
                string[] nc = cards[i].Split(',');

                nCartas = nCartas + Convert.ToInt32(nc[1]);
            }
            
            for (int i = 0; i < nCartas; i++)
            {
                string[] a = cards[i].Split(',');
                simb = a[0];
                
                simb = simb.Replace("\r", "");
                simb = simb.Replace("\n", ""); 
                int copias = Convert.ToInt32(a[1]);
                cartas.Add(new Carta(form, simb));
                cartas[i].Montar(form, 20, 0,list,i);

            }*/
        }
        


    }
}
