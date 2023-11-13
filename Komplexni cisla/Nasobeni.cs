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
    public partial class Nasobeni : Form
    {
        public Nasobeni()
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
                prubeh_a_vysledek.Text = "a * b = ";
            }
            else
            {
                prubeh_a_vysledek.Text = "a * b =  " + vypocti.Vynasob();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vypoceti();   
        }

        private void pustup_Click(object sender, EventArgs e)
        {
            if (prubeh_a_vysledek.Text == "a * b = ")
            {
                MessageBox.Show("Musíš zadat hodnoty než budeš chtít zobrazit řešení", "POZOR");
            }
            else
            { 
                MessageBox.Show(vypocti.PostupNasob());
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Násobení Kalkulačka: Tato kalkulačka počítá s komplexními čísli jako v běžné matematice, takže s výrazy např. (5 + 6i), do levých Textboxů se píšou reálná čísla (ty bez íčka) a do prava imaginární (ty s íčkem), po zadání čísel klikni na tlačítko „Vnásob“ aby se to Vynásobilo, znamínka ve výrazech vyrřeš tím , že tam dáš buď záporné nebo kladné číslo a bude to fungovat, do Textboxu s výsledkem se ti ukáže pouze výsledek, pro postup budeš muset kliknout na tlačítko „Ukaž postup“");
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
    }
}
