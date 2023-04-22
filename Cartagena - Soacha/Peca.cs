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
        public string cor;
        public int casa;
        public Panel newPanel;
        Form2 form;

        public Peca(Form2 form, string cor)
        {
            this.form = form;
            this.cor = cor;
            casa = 0;
        }

        //
        //Aqui vai montar as peças
        //
        public void Montar(string cores, List<Image> list, Form2 form, int x, int y) 
        {
            newPanel = new Panel();
            form.Controls.Add(newPanel);
            newPanel.Size = new Size(20, 20);
            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
            newPanel.BringToFront();
            newPanel.Click += new System.EventHandler(this.VerPos);
                    
            switch(cores)
            {
                case "Vermelho":
                    newPanel.BackgroundImage = list[6];
                    newPanel.Location = new Point(x, y);
                    break;
                case "Verde":
                    newPanel.BackgroundImage = list[7];
                    newPanel.Location = new Point(x + 30, y);
                    break;
                case "Amarelo":
                    newPanel.BackgroundImage = list[8];
                    newPanel.Location = new Point(x, y + 30);
                    break;
                case "Azul":
                    newPanel.BackgroundImage = list[9];
                    newPanel.Location = new Point(x + 30, y + 30);
                    break;
                case "Marrom":
                    newPanel.BackgroundImage = list[10];
                    newPanel.Location = new Point(x + 15, y + 15);
                    break;   
            }
        }

        //
        //Move as peças pra frente e pra tras
        //
        public void Mover(string cor,List<Casa> casas, int pos,Peca peca )
        {
            if(cor == peca.cor)
            {
                int a, b;
                switch(cor)
                {
                    case "Vermelho":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a , b);//canto superior esquerdo
                        this.casa = pos;
                        break;
                    case "Amarelo":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a+30, b);//canto superior direito
                        this.casa = pos;
                        break;
                    case "Azul":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a, b+30);//canto inferior esquerdo
                        this.casa = pos;
                        break;
                    case "Verde":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a + 30, b + 30);//canto inferior direito
                        this.casa = pos;
                        break;
                    case "Marrom":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a + 15, b + 15);//meio
                        this.casa = pos;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Esta Nao é sua peça");
            } 
        }

        public void VerPos(object sender, EventArgs e)
        {
            form.peca = this;
            form.pos = casa;//coloca pos na variavel de posição no form
            form.DefinirPos(casa);//coloca a posição no lblPos
        }
    }
}
