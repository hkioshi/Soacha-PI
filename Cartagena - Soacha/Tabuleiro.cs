using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
using Cartagena___Soacha;

namespace Cartagena___Soacha
{
    public class Tabuleiro
    {
        List<Casa> casas = new List<Casa>();
        int x = 100, y = 0;

        public void GerarTabuleiro(string retorno, Form2 form)
        {
            int id;
            string simb;
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length-2 ; i++)
            {
                string[] strings = partidas[i].Split(',','\r');
                if(i == 0)
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = "inicio";

                }
                else if(i == 37)
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = "barco";
                }
                else
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = strings[1];
                }

                casas.Add(new Casa(id, simb));
                casas[i].Montar(form, x,y);

                x += 70;
                if (x-100 == 10 * 70)
                {
                    x = 0;
                    y += 70;
                }
            }
        }

        
            

    }
}
