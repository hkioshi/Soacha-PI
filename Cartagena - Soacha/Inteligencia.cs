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
        bool final = false, tres;
        bool ex = false, ex1= false, ex2= true;

        public Inteligencia(Suporte suporte) 
        {
            this.suporte = suporte;
        }
        public void Pensar()
        {
            if (suporte.vez)
            {
                Verificar();

                if(suporte.pecasEmJogo == 2 && suporte.mao.nCartas == 2)
                {
                    ex = true;
                    ex1 = true;
                }

                if (suporte.pecasEmJogo <= 2 && suporte.mao.nCartas > 3 || suporte.pecasEmJogo == 1 && suporte.mao.nCartas >= 2)
                {
                    //nesse if ver quantas peças restam no tabuleiro
                    
                    final = true;
                }
                
                if (suporte.mao.nCartas < 3 && !final && !ex && !suporte.deuRuimNaIda && !suporte.deuRuimNaVolta)
                {
                    tres = suporte.Compra();
                }
                else if(ex)
                {
                    if(ex1)
                    {
                        if (suporte.pecas.Count() == 0)
                            suporte.form.End();
                        else
                            suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                    }
                }
                else if(final)
                {
                    if (suporte.pecas.Count() == 0)
                        suporte.form.End();
                    else
                         suporte.Mover(Convert.ToInt32(suporte.pecas[0]), cartaComMaisCopias[0]);
                }
                else if(suporte.deuRuimNaIda)
                {
                    suporte.Mover(suporte.pecaMaisAfrente);
                    
                }
                else if(suporte.deuRuimNaVolta)
                {
                    suporte.Mover(suporte.pecaMaisAfrente);
                    suporte.deuRuimNaVolta = false;
                }
                else if(!ex && !final)
                {
                    if(tres)
                    {
                        suporte.Mover(suporte.pecaCom3, cartaComMenosCopias[0]);
                        tres = false;
                    }
                    else
                    {
                        if (Convert.ToInt32(cartaComMaisCopias[1]) >= 3)
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
                    }            
                }
            }

            void Verificar()
            {
                cartaComMaisCopias = suporte.CartaCmMaisCopias();
                cartaComMenosCopias = suporte.CartaCmMenosCopias();
            }
        }
    }
}
    
    

