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

        public void Montar(Form2 form, int x, int y,int fixo, List<Image> list)
        {
            //
            //Aqui vai fazer o painel e colocar as imagens
            //  
            newButton.Location = new Point(x, y);
            newButton.BorderStyle = BorderStyle.FixedSingle;
            newButton.BackgroundImageLayout = ImageLayout.Stretch;
            newButton.BackColor = System.Drawing.Color.Transparent;

            //fundo
            switch (this.simbolo)
            {
                case "F":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[0];
                    
                    break;
                case "P":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[1];
                    
                    break;
                case "T":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[2];
                    
                    break;
                case "C":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[3];
                    
                    break;
                case "G":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[4];
                    
                    break;
                case "E":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[5];
                    
                    break;
                case "inicio":
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackColor = Color.Aqua;
                    
                    break;
                case "barco":
                    newButton.Size = new Size(100, 75);
                    newButton.BackColor = Color.Brown;
                    
                    break;
            }
            form.Controls.Add(newButton);
        }
    }
}