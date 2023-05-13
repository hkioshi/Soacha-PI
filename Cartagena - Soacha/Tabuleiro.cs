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

namespace Cartagena___Soacha
{
    public class Tabuleiro
    {
        //
        //Construtor do Tabuleiro
        //

        public List<Casa> casas = new List<Casa>();
        public List<Jogador> jogadores = new List<Jogador>();
        int x = 70, y = 20; // coordenadas do tabuleiro
        bool ir = true, desce = false, desce2 = false;// coisas pra fazer o tabuleiro serpentiar
        Form2 form;
        Mao mao = new Mao();
        int turno = 0;

        public Tabuleiro(Form2 form)
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
                casas[i].Montar(form, x, y, list);

                //
                //Essa bizarrice aq é pra fazer o tabuleiro sepentiar
                //
                if (ir && x != 70 * 13)
                {
                    x += 70;
                    if (x == 70 * 13)
                    {
                        desce = true;
                        ir = false;
                    }
                }
                else if (!ir && x != 70)
                {
                    x -= 70;
                    if (x == 70)
                    {
                        desce = true;
                        ir = true;
                    }
                }

                if (desce)
                {
                    y += 70;
                    desce2 = true;
                    desce = false;
                }
                else if (desce2)
                {
                    y += 70;
                    desce2 = false;
                }
            }
        }

        //gera as peças
        public void GerarPecas(List<Image> list, int idJogador,Suporte suporte)
        {
            string cor;
            foreach (Jogador jogador in jogadores)
            {
                if (jogador.id == Convert.ToString(idJogador))
                {
                    for (int i = 0; i < 6; i++)
                    {

                        cor = jogador.cor;
                        jogador.pecas.Add(new Peca(form, cor));
                        if(cor == jogador.cor)
                        suporte.Jogador(jogador);
                        jogador.pecas[i].Montar(cor, list, form, 70, 20);
                        //cor, list, casas, njog, form,70,20
                    }
                    casas[0].numeroDePecas += 6;
                }
                else
                {
                    for (int i = 0; i < 6; i++)
                    {

                        cor = jogador.cor;
                        jogador.pecas.Add(new Peca(form, cor));
                        jogador.pecas[i].Montar(cor, list, form, 70, 20);
                        //cor, list, casas, njog, form,70,20
                    }
                }
                
            }
        }

        public void ListarJogadores(int idPartida)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] retornos2 = retorno.Split('\n');
            for (int i = 0; i < retornos2.Length - 1; i++)
            {
                string[] jogador = retornos2[i].Split(',');
                jogadores.Add(new Jogador(jogador[0], jogador[1], jogador[2]));
            }
        }

        public string VerVez(int idPartida, int jogadorId, Suporte suporte)
        {
            string Tudo;

            string retorno = Jogo.VerificarVez(idPartida);
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

        public void AtualizarTabuleiro(int idPartida)
        {
            string retorno = Jogo.ExibirHistorico(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] retorno1 = retorno.Split('\n');

            while (turno < retorno1.Length-1)
            {
                
                string[] atualizar = retorno1[turno].Split(',');
                if (atualizar[3]!="")
                {
                    foreach (Jogador jogador in jogadores)
                    {
                        if (atualizar[0] == jogador.id)
                        {
                            foreach (Peca peca in jogador.pecas)
                            {

                                if (peca.casa == Convert.ToInt32(atualizar[3]))
                                {
                                    peca.Mover(peca.cor, casas, Convert.ToInt32(atualizar[4]));
                                    turno++;
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                else
                {
                    turno++;
                }

            }
    
            /*
            string retorno = Jogo.VerificarVez(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] retornos = retorno.Split('\n');

            int a = 0;
            foreach (Jogador jogador in jogadores)
            {
                string[] retorno1 = retornos.Where(nome => nome.Contains(jogador.id) && !nome.Contains("J")).ToArray();
                for (int i = 0; i < retorno1.Length; i++)
                {
                    string[] retorno2 = retorno1[i].Split(',');
                    for (int j = 0; j < Convert.ToInt32(retorno2[2]); j++)
                    {
                        jogador.pecas[a].Mover(jogador.cor, casas, Convert.ToInt32(retorno2[0]));
                        a++;
                    }
                }
                a = 0;
            }*/
        }
    }
}

