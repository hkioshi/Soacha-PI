using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
using Cartagena___Soacha;
using System.Drawing;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;

namespace Cartagena___Soacha
{
    public class Tabuleiro
    {
        //
        //Construtor do Tabuleiro
        //

        public List<Casa> casas = new List<Casa>();
        public List<Peca> pecas = new List<Peca>();
        int x = 70, y = 20; // coordenadas do tabuleiro
        bool ir = true, desce =false, desce2 = false;// coisas pra fazer o tabuleiro serpentiar
        Form2 form;
        Mao mao = new Mao(); 
       

        public Tabuleiro(Form2 form)
        {
            this.form = form;
        }

        public void GerarTabuleiro(string retorno, List<Image> list)
        {
            //
            //Isso vai colocar os paineis na tela
            //

            int id;
            string simb;
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length-1 ; i++)
            {
                string[] strings = partidas[i].Split(',','\r');
                if(i == 0)
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = "inicio";//se for o primeiro

                }
                else if(i == 37)
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = "barco";//se for o ultimo
                }
                else
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = strings[1];//entre o primeiro e ultimo
                }
                //Aqui vai colocar os paineis ja com as imagens na tela
                casas.Add(new Casa(id, simb, form));
                casas[i].Montar(form, x,y,list);

                //
                //Essa bizarrice aq é pra fazer o tabuleiro sepentiar
                //
                if (ir && x != 70 * 13)
                {
                    x += 70;
                    if (x == 70 * 13)
                    {
                        desce = true;
                        ir = false;
                    }
                }
                else if (!ir && x != 70 )
                {
                    x -= 70;
                    if (x == 70 )
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

        public void GerarPecas(string retorno, List<Image> list)
        {
            string cor;
            int nPeca = 0;
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');
            for (int i = 0; i < jogadores.Length- 1; i++)
            {
                for(int j = 0;j<6;j++) 
                {
                    string[] a = jogadores[i].Split(',');
                    cor = a[2];
                    cor = cor.Replace("\r", "");
                    cor = cor.Replace("\n", "");
                    pecas.Add(new Peca(form, cor));
                    pecas[nPeca].Montar(cor, list, form, 70, 20);
                    nPeca++;
                    //cor, list, casas, njog, form,70,20
                }
            }
        }

        

    }
}
