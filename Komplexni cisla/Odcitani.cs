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
    public partial class Odcitani : Form
    {
        public Odcitani()
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

        double prehoz_znaminka;

        bool lze1;
        bool lze2;
        bool lze3;
        bool lze4;

        bool parsoval = true;
        public void Upozorneni()
        {
            if (lze1 == false || lze2 == false || lze3 == false || lze4 == false)
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
                if (lze3 == false)
                {
                    realne_cisloB.Text = "";
                }
                if (lze4 == false)
                {
                    imag_cisloB.Text = "";
                }

            }
            else
            {
                parsoval = true;
            }
        }

        public void Vypoceti()
        {
            lze1 = double.TryParse(realne_cisloA.Text, out realcisloA);
            lze2 = double.TryParse(imag_cisloA.Text, out imagcisloA);
            lze3 = double.TryParse(realne_cisloB.Text, out realcisloB);
            lze4 = double.TryParse(imag_cisloB.Text, out imagcisloB);
            Upozorneni();


            vypocti = new Vypocty(realcisloA, realcisloB, imagcisloA, imagcisloB, znaminkoA, znaminkoB);

            if (parsoval == false)
            {
                prubeh_a_vysledek.Text = "a - b = ";
            }
            else
            {
                if (vypocti.VratImagOdecet() < 0)
                {
                    prehoz_znaminka = vypocti.VratImagOdecet() * (-1);
                    prubeh_a_vysledek.Text = "a - b = " + vypocti.VratRealOdecet().ToString() + " + " + prehoz_znaminka.ToString() + "i ";
                }
                else
                {
                    prubeh_a_vysledek.Text = "a - b = " + vypocti.VratRealOdecet().ToString() + " - " + vypocti.VratImagOdecet().ToString() + "i ";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Vypoceti();
        }

        private void pustup_Click(object sender, EventArgs e)
        {
            if (prubeh_a_vysledek.Text == "a - b = ")
            {
                MessageBox.Show("Musíš zadat hodnoty než budeš chtít zobrazit řešení", "POZOR");
            }
            else
            {

                if (vypocti.VratImagOdecet() < 0)
                {

                    MessageBox.Show(vypocti.PostupRealOdcitani() + "\n" + vypocti.PostupImagOdcitani() + "\n" + " Sejdou se zde 2 stejná znamínka u imaginárních čísel takže výsledek je: \n   + " + prehoz_znaminka + "i");
                }
                else
                {
                    MessageBox.Show(vypocti.PostupRealOdcitani() + "\n" + vypocti.PostupImagOdcitani());
                }

            }
            
        }

        private void Odcitani_Load(object sender, EventArgs e)
        {

        }

        private void realne_cisloA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Vypoceti();
            }
        }

        private void imag_cisloA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Vypoceti();
            }
        }

        private void realne_cisloB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Vypoceti();
            }
        }

        private void imag_cisloB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Vypoceti();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odčítání Kalkulačka: Tato kalkulačka počítá s komplexními čísli jako v běžné matematice, takže s výrazy např. (5 + 6i), do levých Textboxů se píšou reálná čísla (ty bez íčka) a do prava imaginární (ty s íčkem), po zadání čísel klikni na tlačítko „Odečti“ aby se to odečetlo, se zápornými čísli si nelam hlavu, program vše zařídí za tebe, do Textboxu s výsledkem se ti ukáže pouze výsledek, pro postup budeš muset kliknout na tlačítko „Ukaž postup“");
        }
    }
}
