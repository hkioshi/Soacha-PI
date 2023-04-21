using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena___Soacha

{
    public class Carta
    {
        public string simbolo { get; set; }
        public Form2 form2 { get; set; }
        public Panel newPanel = new Panel();

        public Carta(Form2 form,string simbolou)
        {
            form2 = form;
            simbolo = simbolou;
        }

        public void Montar(Form2 form, int x, int y, List<Image> list,int i)
        {
            newPanel = new Panel();
            form.Controls.Add(newPanel);
            newPanel.Location = new Point(x+60*i, y);
            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
            newPanel.Click += new System.EventHandler(this.SelecionarSimbolo);
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.BringToFront();
            switch(this.simbolo)
            {
                case "F":
                    newPanel.BackgroundImage = list[0];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "P":
                    newPanel.BackgroundImage = list[1];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "T":
                    newPanel.BackgroundImage = list[2];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "C":
                    newPanel.BackgroundImage = list[3];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "G":
                    newPanel.BackgroundImage = list[4];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "E":
                    newPanel.BackgroundImage = list[5];
                    newPanel.Size = new Size(50, 50);
                    break;
            }
        }
        
        public void SelecionarSimbolo(object sender, EventArgs e)
        {
            form2.simb = this.simbolo;

        }

        public void Desmontar(Form2 form)
        {
            this.newPanel.Click -= new System.EventHandler(this.SelecionarSimbolo);
            form.Controls.Remove(newPanel);
        }


    }
}
