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
        //
        //Cartas  
        //
        public string simbolo { get; set; }//Simbolo
        public Jogo form2 { get; set; }//form
        public Panel newPanel = new Panel();//painel


        public Carta(Jogo form,string simbolou)//construtor
        {
            form2 = form;
            simbolo = simbolou;
        }

        //
        //Aq Vai montar uma carta
        //
        public void Montar(Jogo form, int x, int y, List<Image> list,int i)
        {
            //Caracteristicas/funções do painel
            newPanel = new Panel();
            form.Controls.Add(newPanel);
            newPanel.Location = new Point(x+60*i, y);
            newPanel.BackgroundImageLayout = ImageLayout.Stretch;
            newPanel.Click += new System.EventHandler(this.SelecionarSimbolo);
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.BackColor = System.Drawing.Color.Transparent;
            newPanel.BringToFront();

            //fundo do painel
            switch(this.simbolo)
            {
                case "F"://Faca
                    newPanel.BackgroundImage = list[0];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "P"://Pistola
                    newPanel.BackgroundImage = list[1];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "T"://Chapéu 
                    newPanel.BackgroundImage = list[2];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "C"://Chave
                    newPanel.BackgroundImage = list[3];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "G"://Garrafa
                    newPanel.BackgroundImage = list[4];
                    newPanel.Size = new Size(50, 50);
                    break;
                case "E"://Esqueleto
                    newPanel.BackgroundImage = list[5];
                    newPanel.Size = new Size(50, 50);
                    break;
            }
        }
        
        public void SelecionarSimbolo(object sender, EventArgs e)
        {
            form2.simb = this.simbolo;//Aq ao clicar vai colocar o simbolo numa variavwl de simbolo no forms
            form2.simbolo(simbolo);
        }

        public void Desmontar(Jogo form)
        {
            this.newPanel.Click -= new System.EventHandler(this.SelecionarSimbolo);//tirar a função do painel
            form.Controls.Remove(newPanel);//Excluir painel do forms
        }


    }
}
