using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamponsLeague
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TORBA1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;
            takimlar = new List<Takim>();
            yenitakim = new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Barcelona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Dinamo Zagreb", "Hırvatistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chealsea", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Villareal", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Cluj", "Romanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("PSV", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lyon", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Marsilya", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Celtic", "İskoçya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Rangers", "İskoçya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Fenerbahçe", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Beşiktaş", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Trabzonspor", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussıa Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Wolfsburg", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bayer Leverkusen", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Leipzig", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Benfica", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lisbon", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Kopenhag", "Danimarka");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "İtalya");
            takimlar.Add(yenitakim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int i = 0; i < takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0, takimlar.Count);
                if (secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }

            }

            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    trb1.Items.Add(takimlar[secilentakimlar[i]]);

                }
                else if (i < 16)
                {
                    trb2.Items.Add(takimlar[secilentakimlar[i]]);
                }                          
                else if (i < 24)           
                {                          
                    trb3.Items.Add(takimlar[secilentakimlar[i]]);
                }                          
                else                       
                {                          
                    trb4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(trb1);
            torbalar.Add(trb2);
            torbalar.Add(trb3);
            torbalar.Add(trb4);
            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4);
                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);

                    }
                }
                bool aynıulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakimvar = Aynıulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takim);
                    if (aynıulkedentakimvar) break;
                }
                if (!aynıulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takim);




                }
                else { j--; }
            }
        }
        private bool Aynıulkedentakimvarmi(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.Teamcountry == takim.Teamcountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
            //30.05te kaldım
        }

        private void trb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
