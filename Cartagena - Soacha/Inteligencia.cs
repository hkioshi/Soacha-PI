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
        bool final = false; int umPraDois;



        public Inteligencia(Suporte suporte) 
        {
            this.suporte = suporte;
        }


        public void Pensar()
        {
            if (suporte.vez)
            {
                Verificar();
                if (suporte.mao.nCartas < 3 && !final)
                {
                    suporte.Compra();
                }
                else
                {
                    
                    if (suporte.pecasEmJogo == 1 && final)
                    {
                        if (suporte.pecas.Count() == 0)
                            suporte.form.End();
                        else
                            suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                    }
                    
                    else if (Convert.ToInt32(cartaComMaisCopias[1]) >= 3)
                    {
                        //cada if seria bom ter uma condição pra desconsiderar peças no barco como peça mais avançada
                        //pecaMenor é a peça mais atras 
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                      
                    }
                    else if (Convert.ToInt32(cartaComMaisCopias[1]) == 2)
                    {
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMenosCopias[0]);
                    }
                    else if (Convert.ToInt32(cartaComMaisCopias[1]) == 1)
                    {
                        suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                    }
                    else
                    {
                        suporte.Compra();
                    }
                }
            }

            void Verificar()
            {
                cartaComMaisCopias = suporte.CartaCmMaisCopias();
                cartaComMenosCopias = suporte.CartaCmMenosCopias();
                suporte.Verifica1p2();
            }
        }
    }

}
    
    

