using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace CSHra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player.PlayLooping();
            unmute_button.Visible = false;
            victory.Visible = false;
            continue_victory.Visible = false;
            prohra.Visible = false;
            game_over.Visible = false;
            hide_level_buttons();
        }

        SoundPlayer player = new SoundPlayer("song.wav");
        Mapa mapa;
        Graphics g;
        int pocet_odemcenych_levelu;
        int offset;

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Visible = false;
            uvodni_obrazek.Visible = false;
            System.IO.StreamReader sr = new System.IO.StreamReader("pocet_odemcenych_levelu.txt");
            pocet_odemcenych_levelu = int.Parse(sr.ReadLine());
            offset = int.Parse(sr.ReadLine());
            sr.Close();
            odemkni_levely();
        }

        private void hide_level_buttons()
        {
            label1.Visible = false;
            var Levels = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
            foreach (Button level in Levels)
            {
                level.Visible = false;
            }
        }

        private void odemkni_levely()
        {
            label1.Visible = true;
            victory.Visible = false;
            continue_victory.Visible = false;
            prohra.Visible = false;
            game_over.Visible = false;
            pozadi.Visible = true;
            int odemcene_levely = 0;
            var Levels = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
            foreach (Button level in Levels)
            {
                level.Visible = true;
                if (odemcene_levely < pocet_odemcenych_levelu)
                {
                    odemcene_levely += 1;
                    level.Text = odemcene_levely.ToString();
                    level.ForeColor = Color.Green;
                }
            }
        }

        bool zmena_stavu_kostek = false;
        int cas_do_tahu_priser = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (mapa.stav)
            {
                case Stav.nezacala:
                    break;
                case Stav.bezi:
                    
                    mapa.PohniHrdinou(stisknutaSipka);
                    mapa.VykresliSe(g);
                    zmena_stavu_kostek = mapa.Zmena_Stavu_Kostek();
                    if (zmena_stavu_kostek)
                    {
                        mapa.Premen_Kostky();
                        zmena_stavu_kostek = false;
                    }
                    this.Text = "Zbývá sebrat " + mapa.ZbyvaBananu + " banánů";
                    if (cas_do_tahu_priser < 2)
                    {
                        cas_do_tahu_priser += 1;
                    }
                    else
                    {
                        cas_do_tahu_priser = 0;
                        mapa.PriseryTahnete();
                    }
                    if (mapa.ZbyvaBananu == 0)
                        mapa.stav = Stav.vyhra;
                    break;

                case Stav.vyhra:
                    
                    timer1.Enabled = false;
                    victory.Visible = true;
                    continue_victory.Visible = true;
                    break;

                case Stav.prohra:
                    timer1.Enabled = false;
                    prohra.Visible = true;
                    game_over.Visible = true;
                    break;

                default:
                    break;
            }
        }

        StisknutaSipka stisknutaSipka = StisknutaSipka.zadna;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                stisknutaSipka = StisknutaSipka.nahoru;
                return true;
            }
            if (keyData == Keys.Down)
            {
                stisknutaSipka = StisknutaSipka.dolu;
                return true;
            }
            if (keyData == Keys.Left)
            {
                stisknutaSipka = StisknutaSipka.doleva;
                return true;
            }
            if (keyData == Keys.Right)
            {
                stisknutaSipka = StisknutaSipka.doprava;
                return true;
            }
            if (keyData == Keys.Space)
            {
                stisknutaSipka = StisknutaSipka.mezernik;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            stisknutaSipka = StisknutaSipka.zadna;
        }

        private void mute_button_Click(object sender, EventArgs e)
        {
            player.Stop();
            mute_button.Visible = false;
            unmute_button.Visible = true;
        }

        private void unmute_button_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
            unmute_button.Visible = false;
            mute_button.Visible = true;
        }

        int novy_offset;
        private void button_Click(object sender, EventArgs e)
        {
            var Levels = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
            foreach (Button level in Levels)
            {
                if (sender == level && level.Text != "Locked")
                {
                    novy_offset = level.TabIndex;
                    hide_level_buttons();
                    timer1.Enabled = true;
                    pozadi.Visible = false;
                    g = CreateGraphics();
                    mapa = new Mapa("plan.txt", "ikonky.png", level.TabIndex);
                    this.Text = "Zbývá sebrat " + mapa.ZbyvaBananu + " banánů";
                }
            }
        }

        private void continue_victory_Click(object sender, EventArgs e)
        {
            if (novy_offset > offset)
            {
                pocet_odemcenych_levelu += 1;
                offset = novy_offset;
                TextWriter tw = new StreamWriter("pocet_odemcenych_levelu.txt", false);
                tw.Write(string.Empty);
                tw.Write(pocet_odemcenych_levelu);
                tw.Write("\n");
                tw.Write(offset);
                tw.Close();
            }
            odemkni_levely();
            mapa.stav = Stav.nezacala;
        }

        private void game_over_Click(object sender, EventArgs e)
        {
            odemkni_levely();
            mapa.stav = Stav.nezacala;
        }
    }
}
