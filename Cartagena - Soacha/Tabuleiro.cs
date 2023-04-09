using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
using Cartagena___Soacha;
using System.Drawing;
using System.Security.Cryptography;

namespace Cartagena___Soacha
{
    public class Tabuleiro
    {
        List<Casa> casas = new List<Casa>();
        int x = 210, y = 70;
        bool ir = true, desce =false, desce2 = false;

        public void GerarTabuleiro(string retorno, Form2 form, List<Image> list)
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
                casas[i].Montar(form, x,y,list);


                if (ir && x - 140 != 70 * 12)
                {
                    x += 70;
                    if (x - 140 == 70 * 12)
                    {
                        desce = true;
                        ir = false;
                    }
                }
                else if (!ir && x != 210)
                {
                    x -= 70;
                    if (x == 210)
                    {
                        desce = true;
                        ir = true;
                    }
                }

                if (desce)
                {
                    y += 70;
                    desce2 = true;
                    desce = false;
                }
                else if (desce2)
                {
                    y += 70;
                    desce2 = false;
                }
            }
        }

        
            

    }
}
