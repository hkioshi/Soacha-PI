using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cartagena___Soacha;

namespace Cartagena___Soacha
{
    public class Casa
    {

        public int id ;
        public string simbolo;
        
        
        List<Image> list = new List<Image>();
        Panel newButton = new Panel();


        public Casa(int id, string simb)
        {
            this.id = id;
            this.simbolo = simb;
            
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\DaggerStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\GunStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\HatStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\KeyStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\RumStatic.png"));
                list.Add(Image.FromFile("C:\\Users\\2hkio\\source\\repos\\teste\\imagens\\SkullStatic.png"));
            
            
        }
        public void Montar(Form2 form, int x, int y)
        {
            form.Controls.Add(newButton);
            newButton.Location = new Point(x, y);
            newButton.Size = new Size(50, 50);
            newButton.BorderStyle = BorderStyle.FixedSingle;
            
            if (this.simbolo == "F")
            {
                newButton.BackgroundImage = list[0];
            }
            else if (this.simbolo == "P")
            {
                newButton.BackgroundImage = list[1];
            }
            else if (this.simbolo == "T")
            {
                newButton.BackgroundImage = list[2];
            }
            else if (this.simbolo == "C")
            {
                newButton.BackgroundImage = list[3];
            }
            else if (this.simbolo == "G")
            {
                newButton.BackgroundImage = list[4];
            }
            else if (this.simbolo == "E")
            {
                newButton.BackgroundImage = list[5];
            }


            newButton.BackgroundImageLayout = ImageLayout.Stretch;
            
           
        }
    }
}
