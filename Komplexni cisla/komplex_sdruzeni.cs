using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplexni_cisla
{
    public partial class komplex_sdruzeni : Form
    {
        public komplex_sdruzeni()
        {
            InitializeComponent();
        }

        double realcisloA;
        double realcisloB;
        double imagcisloA;
        double imagcisloB;

        Vypocty vypocti;


        string znaminkoA;
        string znaminkoB;

        bool lze1;
        bool lze2;
        bool parsoval = true;

        public void Upozorneni()
        {
            if (lze1 == false || lze2 == false)
            {
                MessageBox.Show("Něco je špatně. Zkontroluj co zadáváš do kalkulačky ", "POZOR");
                parsoval = false;

                if (lze1 == false)
                {
                    realne_cisloA.Text = "";
                }
                if (lze2 == false)
                {
                    imag_cisloA.Text = "";
                }

            }
            else
            {
                parsoval = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lze1 = double.TryParse(realne_cisloA.Text, out realcisloA);
            lze2 = double.TryParse(imag_cisloA.Text, out imagcisloA);
            Upozorneni();

            if (Aminus.Checked)
            {
                znaminkoA = "-";
            }

            if (Aplus.Checked)
            {
                znaminkoA = "+";
            }

            if (Aplus.Checked == false && Aminus.Checked == false)
            {
                MessageBox.Show("Musíš vybrat znaménko!", "POZOR");
            }

            if (parsoval == false)
            {
                prubeh_a_vysledek.Text = "aˉ = ";
            }
            else 
            { 
                if (znaminkoA == "-")
                {
                    if (imagcisloA < 0)
                    {
                        prubeh_a_vysledek.Text = "aˉ = " + realcisloA + " - " + imagcisloA* (-1);
                    }
                    else
                    {
                        prubeh_a_vysledek.Text = "aˉ = " + realcisloA + " + " + imagcisloA;
                    }
               
                }
            }

            if (znaminkoA == "+")
            {
                if (imagcisloA < 0)
                {
                    prubeh_a_vysledek.Text = "aˉ = " + realcisloA + " + " + imagcisloA*(-1);
                }
                else
                {
                    prubeh_a_vysledek.Text = "aˉ = " + realcisloA + " - " + imagcisloA;
                }
            }

            vypocti = new Vypocty(realcisloA, realcisloB, imagcisloA, imagcisloB, znaminkoA, znaminkoB);
        }

        private void pustup_Click(object sender, EventArgs e)
        {
            if (prubeh_a_vysledek.Text == "aˉ =  ")
            {
                MessageBox.Show("Musíš zadat hodnoty než budeš chtít zobrazit řešení", "POZOR");
            }
            else
            { 
                MessageBox.Show("Zde pouze přetočíme znaménko a vypořádáme se se znamínkama např. u záporných čísel");
            }
        }

        private void komplex_sdruzeni_Load(object sender, EventArgs e)
        {

        }
    }
}
