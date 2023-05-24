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
        bool movimentoInicial = true;
        bool compraDeCartas = false;
        string[] cartaComMaisCopias;


        public Inteligencia(Suporte suporte) 
        {
            this.suporte = suporte;
        }


        public void Pensar()
        {
            if(suporte.vez)
            {
                if(movimentoInicial) 
                {
                    if(turno== 1)
                    {
                        cartaComMaisCopias = suporte.CartaCmMaisCopias();
                        suporte.Mover();
                    }
                }
                if (suporte.mao.nCartas > 3 && !compraDeCartas)
                {

                     cartaComMaisCopias = suporte.CartaCmMaisCopias();

                }
                else
                {
                    
                }
            }
            
        }
    }
}
