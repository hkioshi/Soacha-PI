using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cartagena___Soacha
{
    public class Peca
    {
        
        int fixo = 30;
        public string cor;
        public int casa;
        public Panel newPanel = new Panel();
        Jogo form;

        public Peca(Jogo form, string cor)
        {
            this.form = form;
            this.cor = cor;
            casa = 0;
        }

        //
        //Aqui vai montar as peças
        //
        public void Montar(string cores, List<Casa> casas, List<Image> list, Jogo form)
        {
            int a, b;
            a = casas[0].newButton.Location.X; b = casas[0].newButton.Location.Y;
            this.newPanel.Location = new Point(a, b);//canto superior esquerdo

            newPanel.Size = new Size(fixo, fixo);
            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
            newPanel.Click += new System.EventHandler(this.VerPos);
            newPanel.BackColor = System.Drawing.Color.Transparent;

            switch (cores)
            {
                case "Vermelho":
                    newPanel.Location = new Point(a, b);
                    newPanel.BackgroundImage = list[0];
                    
                    break;
                case "Verde":
                    newPanel.Location = new Point(a + fixo + 10, b);
                    newPanel.BackgroundImage = list[3];
                    
                    break;
                case "Amarelo":
                    newPanel.Location = new Point(a, b + fixo + 10);
                    newPanel.BackgroundImage = list[6];
                    
                    break;
                case "Azul":
                    newPanel.Location = new Point( a + fixo + 10,b+ fixo + 10);
                    newPanel.BackgroundImage = list[9];
                    
                    break;
                case "Marrom":
                    newPanel.Location = new Point(a + fixo / 2 + 10, b+ fixo / 2 + 10);
                    newPanel.BackgroundImage = list[12];
                 
                    break;
            }
            form.Controls.Add(newPanel);
            
            foreach(Peca peca in casas[0].pecas)
            {
                casas[0].newButton.SendToBack();
            }
        }
        //
        //Move as peças pra frente e pra tras
        //
        public int Mover(string cor, List<Casa> casas, int pos, List<Image> PImage)
        {
            if (cor == this.cor)
            {
                int a, b;
                switch (cor)
                {
                    case "Vermelho":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        this.newPanel.Location = new Point(a, b);//canto superior esquerdo
                        casas[casa].numeroDePecas -= 1;
                        casas[casa].pecas.Remove(this);
                        

                        Peca[] pecs = casas[casa].pecas.Where(temp => temp.cor == "Vermelho").ToArray();
                        if (pecs.Length == 1)
                        {
                            pecs[pecs.Length - 1].newPanel.BackgroundImage = PImage[0];

                        }
                        else if (pecs.Length == 2)
                        {
                            pecs[pecs.Length - 1].newPanel.BackgroundImage = PImage[1];
                        }
                        else if(pecs.Length == 1)
                        {
                            pecs[pecs.Length - 1].newPanel.BackgroundImage = PImage[2];
                        }
                        this.casa = pos;
                        //Muda Numero de peças na casa
                        casas[casa].numeroDePecas += 1;
                        casas[casa].pecas.Add(this);
                        newPanel.BringToFront();

                         pecs = casas[casa].pecas.Where(temp => temp.cor == "Vermelho").ToArray();
                        if(pecs.Length == 1) 
                        {
                            pecs[pecs.Length-1].newPanel.BackgroundImage = PImage[0];
                            
                        }
                        else if(pecs.Length == 2) 
                        {
                            pecs[pecs.Length-1].newPanel.BackgroundImage = PImage[1];
                        }
                        else
                        {
                            pecs[pecs.Length-1].newPanel.BackgroundImage= PImage[2];
                        }

                        return casa;
                    case "Verde":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        this.newPanel.Location = new Point(a + fixo +10, b);//canto superior direito
                        casas[casa].numeroDePecas -= 1;
                        casas[casa].pecas.Remove(this);
                        this.casa = pos;

                        //Muda Numero de peças na casa
                        casas[casa].numeroDePecas += 1;
                        casas[casa].pecas.Add(this);
                        newPanel.BringToFront();



                        return casa;
                    case "Amarelo":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        this.newPanel.Location = new Point(a, b + fixo + 10);//canto inferior esquerdo
                        casas[casa].numeroDePecas -= 1;
                        casas[casa].pecas.Remove(this);
                        this.casa = pos;

                        //Muda Numero de peças na casa
                        casas[casa].numeroDePecas += 1;
                        casas[casa].pecas.Add(this);
                        newPanel.BringToFront();


                        return casa;
                    case "Azul": 
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        this.newPanel.Location = new Point(a + fixo + 10, b + fixo + 10);//canto inferior direito
                        casas[casa].numeroDePecas -= 1;
                        casas[casa].pecas.Remove(this);
                        this.casa = pos;
                        newPanel.BringToFront();

                        //Muda Numero de peças na casa
                        casas[casa].numeroDePecas += 1;
                        casas[casa].pecas.Add(this);
                        newPanel.BringToFront();

                        return casa;

                    case "Marrom":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        this.newPanel.Location = new Point(a + fixo / 2 + 10, b + fixo / 2 + 10);//meio
                        casas[casa].numeroDePecas -= 1;
                        casas[casa].pecas.Remove(this);
                        this.casa = pos;

                        //Muda Numero de peças na casa
                        casas[casa].numeroDePecas += 1;
                        casas[casa].pecas.Add(this);
                        newPanel.BringToFront();
                        return casa;

                }
            }
            else
            {
                MessageBox.Show("Esta Nao é sua peça");
                return -1;
            }
            return -1;
        }

        public void VerPos(object sender, EventArgs e)
        {
            form.peca = this;
            form.pos = casa;//coloca pos na variavel de posição no form
            form.posicao(casa);
        }
    }
}
