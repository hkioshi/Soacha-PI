using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartagenaServer;
using Cartagena___Soacha;
using System.Drawing;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cartagena___Soacha
{
    public class Tabuleiro
    {
        //
        //Construtor do Tabuleiro
        //
        public List<Casa> casas = new List<Casa>();
        public List<Jogador> jogadores = new List<Jogador>();
        int x = 90, y = 20, fixo = 90; // coordenadas do tabuleiro
        bool ir = true, desce = false;// coisas pra fazer o tabuleiro serpentiar
        Tela form;
        Mao mao = new Mao();
        int turno = 0;

        public Tabuleiro(Tela form)
        {
            this.form = form;
        }

        //gera o tabuleiro
        public void GerarTabuleiro(string retorno, List<Image> list)
        {
            //
            //Isso vai colocar os paineis na tela
            //

            int id;
            string simb;
            string[] partidas = retorno.Split('\n');
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                string[] strings = partidas[i].Split(',', '\r');
                if (i == 0)
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = "inicio";//se for o primeiro

                }
                else if (i == 37)
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = "barco";//se for o ultimo
                }
                else
                {
                    id = Convert.ToInt32(strings[0]);
                    simb = strings[1];//entre o primeiro e ultimo
                }
                //Aqui vai colocar os paineis ja com as imagens na tela
                casas.Add(new Casa(id, simb, form));
                casas[i].Montar(form, x, y, fixo, list);

                //
                //Essa bizarrice aq é pra fazer o tabuleiro sepentiar
                //
                DefX();
            }
        }

        //posiçãox
        public void DefX()
        {
            if (ir)
            {
                if (x < fixo * 13)
                {
                    x += fixo;
                }
                else
                {
                    DefY();
                }
            }
            else
            {
                if (x > fixo * 2)
                {
                    x -= fixo;
                }
                else
                {
                    DefY();
                }
            }

        }
        //posiçãoy
        public void DefY()
        {
            if (ir && !desce)
            {
                x += fixo;
                y += fixo;
                desce = true;
            }
            else if (ir && desce)
            {
                y += fixo;
                x -= fixo;
                ir = false;
                desce = false;
            }
            else if (!ir && !desce)
            {
                x -= fixo;
                y += fixo;
                desce = true;
            }
            else if (!ir && desce)
            {
                y += fixo;
                x += fixo;
                ir = true;
                desce = false;
            }

        }
    

        //
        //gera as peças
        //
        public void GerarPecas(List<Image> list, int idJogador, Suporte suporte)
        {
            int j= 0;
            string cor;
            foreach (Jogador jogador in jogadores)
            {
               
                if (jogador.id == Convert.ToString(idJogador))
                {
                    suporte.Jogador(jogador);
                }
                
                for (int i = 0; i < 6; i++)
                {
                    cor = jogador.cor;
                    casas[0].pecas.Add(new Peca(form, cor));
                    casas[0].pecas[i+6*j].Montar(cor, casas,list, form);
                    //cor, list, casas, njog, form,70,20   
                }
                j++;
                casas[0].numeroDePecas += 6;
                for(int i = 0;i < 6;i++)
                    casas[0].newButton.SendToBack();

            }
        }

        //
        // Aqui Onde Os Jogadores são listados
        //
        public void ListarJogadores(int idPartida)
        {
            string retorno = CartagenaServer.Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] retornos2 = retorno.Split('\n');
            for (int i = 0; i < retornos2.Length - 1; i++)
            {
                string[] jogador = retornos2[i].Split(',');
                jogadores.Add(new Jogador(jogador[0], jogador[1], jogador[2]));
            }
        }

        //
        //Ver de quem é a vez
        //
        public string VerVez(int idPartida, int jogadorId, Suporte suporte)
        {
            string Tudo;

            string retorno = CartagenaServer.Jogo.VerificarVez(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] retornos = retorno.Split('\n');
            retornos = retornos[0].Split(',');
            foreach (Jogador jogador in jogadores)
            {
                if (Convert.ToInt32(retornos[1]) == jogadorId)
                {
                    suporte.vez = true;
                }
                else
                {
                    suporte.vez = false;
                }

                if (jogador.id == retornos[1])
                {
                    Tudo = $"{jogador.nome} - {jogador.cor} - {retornos[2]}";
                    return Tudo;
                }

            }
            return "erro, Jogador Nao encontrado";

        }

        //
        //Mover pecas no tabuleiro graficamente
        //
        public string AtualizarTabuleiro(int idPartida, Suporte suporte)
        {
            int ret;
            string retorno = Jogo.ExibirHistorico(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] retorno1 = retorno.Split('\n');

            while (turno < retorno1.Length - 1)
            {
                string[] atualizar = retorno1[turno].Split(',');
                if (atualizar[3] != "")
                {
                    Jogador[] jogs = jogadores.Where(jogador => jogador.id.Contains(atualizar[0])).ToArray();
                    foreach (Peca peca in casas[Convert.ToInt32(atualizar[3])].pecas)
                    {
                        if (jogs[0].cor == peca.cor)
                        {
                            ret = peca.Mover(peca.cor, casas, Convert.ToInt32(atualizar[4]),form.listP);
                            turno++;
                            return ret.ToString();
                        }
                    }
                    break;
                }
                else
                {
                    turno++;
                }

            }
            return "erro";
        }
    }
}