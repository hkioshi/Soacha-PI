using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cartagena___Soacha
{
    public class Inteligencia
    {
        Suporte suporte;
        int turno = 1 ;
        int contador = 0;
        bool movimentoInicial = false;
        bool compraDeCartas;

         
        public Inteligencia(Suporte suporte) 
        {
            this.suporte = suporte;
        }


        public void Pensar()
        {
            string s = "s";
            string copias;
           for(int i = 0; i < 6; i++) 
            {
                if (Convert.ToInt32(suporte.cartas[i,1]) > 2)
                {
                    s = suporte.cartas[i,0];
                }

            }
            
        }
    }
}
