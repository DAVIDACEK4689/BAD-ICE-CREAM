using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace CSHra
{
    abstract class PohyblivyPrvek
    {
        public Mapa mapa;
        public int x;
        public int y;
        public char Smer;
        public abstract void UdelejKrok();
    }

    enum StisknutaSipka { zadna, doleva, nahoru, doprava, dolu, mezernik };
   
    class Hrdina : PohyblivyPrvek
    {
        public Hrdina(Mapa mapa, int kdex, int kdey)
        {
            this.mapa = mapa;
            this.x = kdex;
            this.y = kdey;
            Smer = 'a';
        }
        public override void UdelejKrok()
        {
            int nove_x = x;
            int nove_y = y;
            bool strelba_ledu = false;

            switch (mapa.stisknutaSipka)
            {
                case StisknutaSipka.zadna:
                    break;
                case StisknutaSipka.doleva:
                    if (Smer == 'b')
                        nove_x -= 1;
                    else
                        Smer = 'b';
                    break;
                case StisknutaSipka.nahoru:
                    if (Smer == 'd')
                        nove_y -= 1;
                    else
                        Smer = 'd';
                    break;
                case StisknutaSipka.doprava:
                    if (Smer == 'c')
                        nove_x += 1;
                    else
                        Smer = 'c';
                    break;
                case StisknutaSipka.dolu:
                    if (Smer == 'a')
                        nove_y += 1;
                    else
                        Smer = 'a';
                    break;
                case StisknutaSipka.mezernik:
                    strelba_ledu = true;
                    break;
                default:
                    break;
            }

            if (x == nove_x && y == nove_y)
                mapa.Otochrdinu();
            

            if (mapa.JeVolno(nove_x, nove_y))
                mapa.Presunhrdinu(x, y, nove_x, nove_y);
            

            if (mapa.JeBanan(nove_x,nove_y))
                mapa.SeberBanan(x, y, nove_x, nove_y);
            

            if (mapa.JePrisera(nove_x, nove_y))
                mapa.stav = Stav.prohra;
            

            if (strelba_ledu)
            {
                switch (Smer)
                {
                    case 'a':
                        if (mapa.JeKostka(nove_x, nove_y+1))
                        {
                            mapa.SmazKostku(nove_x, nove_y, 0, 1);
                        }
                        else if (mapa.JeVolno(nove_x, nove_y + 1) || mapa.JeBanan(nove_x, nove_y + 1))
                        {
                            mapa.PostavKostku(nove_x, nove_y, 0, 1);
                        }
                        break;

                    case 'b':
                        if (mapa.JeKostka(nove_x-1, nove_y))
                        {
                            mapa.SmazKostku(nove_x, nove_y, -1, 0);
                        }
                        else if (mapa.JeVolno(nove_x-1, nove_y) || mapa.JeBanan(nove_x-1, nove_y))
                        {
                            mapa.PostavKostku(nove_x, nove_y, -1, 0);
                        }
                        break;

                    case 'c':
                        if (mapa.JeKostka(nove_x+1, nove_y))
                        {
                            mapa.SmazKostku(nove_x, nove_y, 1, 0);
                        }
                        else if (mapa.JeVolno(nove_x+1, nove_y) || mapa.JeBanan(nove_x+1, nove_y))
                        {
                            mapa.PostavKostku(nove_x, nove_y, 1, 0);
                        }
                        break;

                    case 'd':
                        if (mapa.JeKostka(nove_x, nove_y - 1))
                        {
                            mapa.SmazKostku(nove_x, nove_y, 0, -1);
                        }
                        else if (mapa.JeVolno(nove_x, nove_y - 1) || mapa.JeBanan(nove_x, nove_y - 1))
                        {
                            mapa.PostavKostku(nove_x, nove_y, 0, -1);
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }

    class Prisera : PohyblivyPrvek
    {
        public Prisera(Mapa mapa, int kdex, int kdey, char charSmer)
        {
            this.mapa = mapa;
            this.x = kdex;
            this.y = kdey;
            Smer = charSmer;

        }
        public override void UdelejKrok()
        {
            int smer_x = 0;
            int smer_y = 0;
            Random rnd = new Random();
            int[] tahy1 = new int[8] {1, 0, 0, -1, -1, 0, 0, 1};
            char[] znak_tahy1 = new char[4] { '>', '^', '<', 'v' };
            int[] tahy2 = new int[8] { 0, 1, -1, 0, 0, -1, 1, 0};
            char[] znak_tahy2 = new char[4] { 'v', '<', '^', '>' };

            if (Smer == '<')
                smer_x = -1;
            else if (Smer == '>')
                smer_x = 1;
            else if (Smer == '^')
                smer_y = -1;
            else
                smer_y = 1;

            if (mapa.JeBanan(x+smer_x, y+smer_y) || mapa.JeVolno(x+smer_x, y+smer_y))
            {
                mapa.Presunpriseru(x, y, x + smer_x, y + smer_y, Smer);
                x = x + smer_x;
                y = y + smer_y;
            }
            else if (mapa.JeHrdina(x + smer_x, y + smer_y))
            {
                mapa.stav = Stav.prohra;
            }
            else 
            {
                int i = 0;
                if (rnd.Next(1,3) == 1)
                {
                    {
                    while (mapa.JeStenaPriseraneboKostka(x + tahy1[i], y + tahy1[i + 1]) && i < 6)
                            i += 2;
                    }
                    Smer = znak_tahy1[i/2];
                    mapa.Otocpriseru(x, y, Smer);

                }
                else
                {
                    while (mapa.JeStenaPriseraneboKostka(x + tahy2[i], y + tahy2[i + 1]) && i < 6)
                    {
                        i += 2;
                    }
                    Smer = znak_tahy2[i/2];
                    mapa.Otocpriseru(x, y, Smer);
                }

            }
        }

    }


    public enum Stav { nezacala, bezi, vyhra, prohra };
    class Mapa
    {
        private char[,] plan;
        private bool[,] banany_plan;
        int sirka;
        int vyska;
        public int ZbyvaBananu;

        public Stav stav = Stav.nezacala;


        Bitmap[] ikonky;
        int sx;

        public Hrdina hrdina;
        public List<PohyblivyPrvek> Prisery;

        public StisknutaSipka stisknutaSipka;


        public Mapa(string cestaMapa, string cestaIkonky, int offset)
        {
            NactiIkonky(cestaIkonky);
            NactiMapu(cestaMapa, offset);
            stav = Stav.bezi;
        }

        public void Presunpriseru(int zX, int zY, int naX, int naY, char ikonka)
        {
            plan[zX, zY] = ' ';
            plan[naX, naY] = ikonka;
        }

        public void Presunhrdinu(int zX, int zY, int naX, int naY)
        {
                plan[zX, zY] = ' ';
                plan[naX, naY] = hrdina.Smer;
                hrdina.x = naX;
                hrdina.y = naY;
        }

        public void Otochrdinu()
        {
            plan[hrdina.x, hrdina.y] = hrdina.Smer;
        }

        public void Otocpriseru(int x,int y, char Smer)
        {
            plan[x, y] = Smer;
        }


        public bool JeVolno(int x, int y)
        {
            return (plan[x, y] == ' ');
        }


        public bool JeStenaPriseraneboKostka(int x, int y)
        {
            return (plan[x, y] == 'X' || plan[x, y] == 'i' || plan[x, y] == '<' || plan[x, y] == '^' || plan[x, y] == 'v' || plan[x, y] == '>');
        }

        public bool JeBanan(int x, int y)
        {
            return (plan[x, y] == 'B');
        }

        public bool JeKostka(int x, int y)
        {
            return (plan[x, y] == 'i');
        }

        public void SeberBanan(int zX, int zY, int naX, int naY)
        {
            plan[zX, zY] = ' ';
            plan[naX, naY] = hrdina.Smer;
            banany_plan[naX, naY] = false;
            hrdina.x = naX;
            hrdina.y = naY;
            ZbyvaBananu -= 1;
        }

        public void PostavKostku(int x, int y, int smer_x, int smer_y)
        {
            plan[x + smer_x, y + smer_y] = 'n';
            if (JeVolno(x + 2 * smer_x, y + 2 * smer_y) || JeBanan(x + 2 * smer_x, y + 2 * smer_y))
            {
                PostavKostku(x + smer_x, y + smer_y, smer_x, smer_y);
            }
        }

        public void SmazKostku(int x, int y, int smer_x, int smer_y)
        {
            plan[x + smer_x, y + smer_y] = 'r';
            if (JeKostka(x + 2 * smer_x, y + 2 * smer_y))
            {
                SmazKostku(x + smer_x, y + smer_y, smer_x, smer_y);
            }
        }

        public bool JePrisera(int x, int y)
        {
            return (plan[x, y] == '<' || plan[x, y] == '^' || plan[x, y] == 'v' || plan[x, y] == '>');
        }

        public bool JeHrdina(int x, int y)
        {
            return (plan[x, y] == 'a' || plan[x, y] == 'b' || plan[x, y] == 'c' || plan[x, y] == 'd');
        }


        public void NactiMapu(string cesta, int offset)
        {
            Prisery = new List<PohyblivyPrvek>();

            System.IO.StreamReader sr = new System.IO.StreamReader(cesta);
            for (int i = 0; i<offset; i++)
            {
                sr.ReadLine();
            }
            sirka = int.Parse(sr.ReadLine());
            vyska = int.Parse(sr.ReadLine());
            plan = new char[sirka, vyska];
            banany_plan = new bool[sirka, vyska];
            ZbyvaBananu = 0;

            for (int y = 0; y < vyska; y++)
            {
                string radek = sr.ReadLine();
                for (int x = 0; x < sirka; x++)
                {
                    char znak = radek[x];
                    plan[x, y] = znak;

                    
                    switch (znak)
                    {
                        case 'a':
                            this.hrdina = new Hrdina(this, x, y);
                            break;

                        case '<':
                        case '^':
                        case '>':
                        case 'v':
                            Prisera prisera = new Prisera(this, x, y, znak);
                            Prisery.Add(prisera);
                            break;

                        case 'B':
                            banany_plan[x, y] = true;
                            ZbyvaBananu += 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            sr.Close();
        }
        public void NactiIkonky(string cesta)
        {
            Bitmap bmp = new Bitmap(cesta);
            this.sx = bmp.Height;
            int pocet = bmp.Width / sx;
            ikonky = new Bitmap[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Rectangle rect = new Rectangle(i * sx, 0, sx, sx);
                ikonky[i] = bmp.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
            }
        }

        public void VykresliSe(Graphics g)
        {
            int sirkaVyrezu = Math.Min(16, sirka);
            int vyskaVyrezu = Math.Min(11, vyska);

            int dx = hrdina.x - sirkaVyrezu / 2;
            if (dx < 0)
                dx = 0;
            if (dx + sirkaVyrezu - 1 >= this.sirka)
                dx = this.sirka - sirkaVyrezu;

            int dy = hrdina.y - vyskaVyrezu / 2;
            if (dy < 0)
                dy = 0;
            if (dy + vyskaVyrezu - 1 >= this.vyska)
                dy = this.vyska - vyskaVyrezu;

            for (int x = 0; x < sirkaVyrezu; x++)
            {
                for (int y = 0; y < vyskaVyrezu; y++)
                {
                    int mx = dx + x;
                    int my = dy + y;

                    if (JeVolno(mx, my) && banany_plan[mx,my] == true)
                    {
                        plan[mx, my] = 'B';
                    }

                    char c = plan[mx, my];
                    if (JeKostka(mx, my) && banany_plan[mx, my] == true)
                    {
                        c = '?';
                    }
                    int indexObrazku = " abcdv<>^iXBrn?".IndexOf(c);
                    g.DrawImage(ikonky[indexObrazku], x * sx, y * sx);
                }
            }
        }

        public void PohniHrdinou(StisknutaSipka stisknutaSipka)
        {
            this.stisknutaSipka = stisknutaSipka;
            hrdina.UdelejKrok();
        }

        public bool Zmena_Stavu_Kostek()
        {
            for (int x = 0; x < sirka; x++)
            {
                for (int y = 0; y < vyska; y++)
                {
                    if (plan[x, y] == 'n' || plan[x, y] == 'r')
                        return true;
                }
            }
            return false;
        }

        public void Premen_Kostky()
        {
            for (int x = 0; x < sirka; x++)
            {
                for (int y = 0; y < vyska; y++)
                {
                    if (plan[x, y] == 'n')
                        plan[x, y] = 'i';

                    else if (plan[x, y] == 'r')
                        plan[x, y] = ' ';

                }
            }
        }

        public void PriseryTahnete()
        {
            foreach (PohyblivyPrvek p in Prisery)
            {
                p.UdelejKrok();
            }
        }
    }
}
