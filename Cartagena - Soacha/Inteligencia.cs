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
        
        string[] cartaComMaisCopias, cartaComMenosCopias;


        public Inteligencia(Suporte suporte) 
        {
            this.suporte = suporte;
        }


        public void Pensar()
        {
            
            if (suporte.vez)
            {
                if ( suporte.mao.nCartas < 4)
                {
                    Compra();
                }
                else 
                {
                    cartaComMaisCopias = suporte.CartaCmMaisCopias();
                    cartaComMenosCopias = suporte.CartaCmMenosCopias();
                    if (suporte.pecasEmJogo <= 2 && suporte.mao.nCartas < 3)
                    {
                        //nesse if ver quantas peças restam no tabuleiro
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                    }
                    else if (Convert.ToInt32(cartaComMaisCopias[1]) >= 3)
                    {
                        //cada if seria bom ter uma condição pra desconsiderar peças no barco como peça mais avançada
                        //pecaMenor é a peça mais atras 
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                        //analisa
                    }
                    else if (Convert.ToInt32(cartaComMaisCopias[1]) == 2)
                    {
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMenosCopias[0]);


                    }
                    else if (Convert.ToInt32(cartaComMaisCopias[1]) == 1)
                    {
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);

                        //analisa
                    }
                else
                {
                    Compra();
                }
                }
            }

        }

        public void Compra()
        {
            suporte.Mover(suporte.pecaMaisAfrente);
        }

    }

}
    
    

