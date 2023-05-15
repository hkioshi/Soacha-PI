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
            if(suporte.vez && turno <= 3)
            {
                if(suporte.mao.nCartas <= 2) 
                {
                    suporte.Mover(suporte.pecaMaisAfrente);
                    
                    turno++;
                }
                if(suporte.pecaMaisAfrente == 0)
                {
                    movimentoInicial=true;
                }
                if(movimentoInicial)
                {
                    suporte.Mover(0, suporte.mao.cartas[0].simbolo);
                    contador++;
                    turno++;
                    if(contador == 3)
                    {
                        movimentoInicial = false;
                        contador = 0;
                    }
                }
                if(turno > 3)
                {
                    suporte.vez= false;
                    turno = 1;
                }
            }
        }
    }
}
