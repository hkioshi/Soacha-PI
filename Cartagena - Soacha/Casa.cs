using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cartagena___Soacha;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cartagena___Soacha
{
    public class Casa
    {
        public int id;
        public string simbolo;
        public int numeroDePecas = 0;
        public Panel newButton = new Panel();
        Form2 form;
        public List<Peca> pecas = new List<Peca>();



        public Casa(int id, string simb, Form2 form)
        {
            //
            //Construtor
            //

            this.id = id;
            this.simbolo = simb;
            this.form = form;
        }

        public void Montar(Form2 form, int x, int y, List<Image> list)
        {
            //
            //Aqui vai fazer o painel e colocar as imagens
            //

            form.Controls.Add(newButton);
            newButton.Location = new Point(x, y);
            newButton.BorderStyle = BorderStyle.FixedSingle;
            newButton.BackgroundImageLayout = ImageLayout.Stretch;

            //fundo
            switch (this.simbolo)
            {
                case "F":
                    newButton.BackgroundImage = list[0];
                    newButton.Size = new Size(50, 50);
                    break;
                case "P":
                    newButton.BackgroundImage = list[1];
                    newButton.Size = new Size(50, 50);
                    break;
                case "T":
                    newButton.BackgroundImage = list[2];
                    newButton.Size = new Size(50, 50);
                    break;
                case "C":
                    newButton.BackgroundImage = list[3];
                    newButton.Size = new Size(50, 50);
                    break;
                case "G":
                    newButton.BackgroundImage = list[4];
                    newButton.Size = new Size(50, 50);
                    break;
                case "E":
                    newButton.BackgroundImage = list[5];
                    newButton.Size = new Size(50, 50);
                    break;
                case "inicio":
                    newButton.BackColor = Color.Aqua;
                    newButton.Size = new Size(50, 50);
                    break;
                case "barco":
                    newButton.BackColor = Color.Brown;
                    newButton.Size = new Size(100, 75);
                    break;
            }
        }
    }
}