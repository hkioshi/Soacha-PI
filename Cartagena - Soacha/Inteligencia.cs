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
        string[] cartaComMaisCopias, cartaComMenosCopias;


        public Inteligencia(Suporte suporte) 
        {
            this.suporte = suporte;
        }


        public void Pensar()
        {
            if (suporte.vez)
            {
                if (movimentoInicial)
                {
                    if (turno == 1)
                    {
                        cartaComMaisCopias = suporte.CartaCmMaisCopias();
                        cartaComMenosCopias = suporte.CartaCmMenosCopias();
                        suporte.Mover(suporte.pecaMaisAfrente, cartaComMenosCopias[0]);
                        movimentoInicial = false;
                    }
                }
                if (suporte.mao.nCartas > 3 && !compraDeCartas)
                {
                    cartaComMaisCopias = suporte.CartaCmMaisCopias();
                    if (Convert.ToInt32(cartaComMaisCopias[1]) >= 3)
                    {
                        //cada if seria bom ter uma condição pra desconsiderar peças no barco como peça mais avançada
                        //pecaMenor é a peça mais atras 
                        suporte.Mover(Convert.ToInt32( suporte.pecas[0]), cartaComMaisCopias[0]);
                        //analis
                    }

                    if (Convert.ToInt32(cartaComMaisCopias[1]) == 2)
                    {


                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMenosCopias[0]);


                    }

                    if (Convert.ToInt32(cartaComMaisCopias[1]) == 1)
                    {
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                        
                        //analisa
                    }
                }
                else if (suporte.pecasEmJogo <= 2)
                {
                    //nesse if ver quantas peças restam no tabuleiro
                    suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                }
                else
                {
                    suporte.Mover(suporte.pecaMaisAfrente);

                }
                
            }

        }
    }
}
    

