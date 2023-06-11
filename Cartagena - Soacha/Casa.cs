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
        Tela form;
        public List<Peca> pecas = new List<Peca>();



        public Casa(int id, string simb, Tela form)
        {
            //
            //Construtor
            //

            this.id = id;
            this.simbolo = simb;
            this.form = form;
        }

        public void Montar(Tela form, int x, int y,int fixo, List<Image> list)
        {
            //
            //Aqui vai fazer o painel e colocar as imagens
            //  
            newButton.Location = new Point(x, y);//posicao
            newButton.BorderStyle = BorderStyle.FixedSingle;//Borda
            newButton.BackgroundImageLayout = ImageLayout.Stretch;//Deixar a imagem do background esticada
            newButton.BackColor = System.Drawing.Color.Transparent;//cor do botao

            //Posição do peça em relação do simbolo
            switch (this.simbolo)
            {
                case "F"://Faca
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[0];
                    
                    break;
                case "P"://pistola
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[1];
                    
                    break;
                case "T"://Chapeu
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[2];
                    
                    break;
                case "C"://Chave
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[3];
                    
                    break;
                case "G"://Garrafa
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[4];
                    
                    break;
                case "E"://Esqueleto
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackgroundImage = list[5];
                    
                    break;
                case "inicio"://inicio
                    newButton.Size = new Size(fixo - 20, fixo - 20);
                    newButton.BackColor = Color.Transparent;
                    
                    break;
                case "barco"://Barco
                    newButton.Size = new Size(100, 75);
                    newButton.BackColor = Color.Brown;
                    
                    break;
            }
            form.Controls.Add(newButton);// Coloca em tela
        }
    }
}