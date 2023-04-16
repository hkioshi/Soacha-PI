using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Montar(string cores, List<Image> list, Form2 form, int x, int y) 
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < cores.Length; j++)
                {
                    newPanel = new Panel();
                    form.Controls.Add(newPanel);
                    newPanel.Location = new Point(x, y);
                    newPanel.Size = new Size(20, 20);
                    newPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    newPanel.BringToFront();
                    newPanel.Click += new System.EventHandler(this.VerPos);
                    if (cores == "Vermelho")
                    {
                        newPanel.BackgroundImage = list[6];
                        newPanel.Location = new Point(x, y);
                    }
                    else if (cores == "Verde")
                    {
                        newPanel.BackgroundImage = list[7];
                        newPanel.Location = new Point(x + 30, y);
                    }
                    else if (cores == "Amarelo")
                    {
                        newPanel.BackgroundImage = list[8];
                        newPanel.Location = new Point(x, y + 30);
                    }
                    else if (cores == "Azul")
                    {
                        newPanel.BackgroundImage = list[9];
                        newPanel.Location = new Point(x + 30, y + 30);
                    }
                    else if (cores == "Marrom")
                    {
                        newPanel.BackgroundImage = list[10];
                        newPanel.Location = new Point(x + 15, y + 15);
                    }
                }
            }
        }
        public void Mover(string cor,List<Casa> casas, int pos,Peca peca )
        {
            if(cor == peca.cor)
            {
                int a, b;
                switch(cor)
                {
                    case "Vermelho":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a , b);
                        break;
                    case "Amarelo":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a+30, b);
                        break;
                    case "Azul":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a, b+30);
                        break;
                    case "Verde":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a + 30, b + 30);
                        break;
                    case "Marrom":
                        a = casas[pos].newButton.Location.X; b = casas[pos].newButton.Location.Y;
                        peca.newPanel.Location = new Point(a + 15, b + 15);
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
            form.pos = casa;

        }

    }
}
