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
    public partial class goniometrie : Form
    {
        public goniometrie()
        {
            InitializeComponent();
        }

        double realcisloA;
        double imagcisloA;
        double realcisloB;
        double imagcisloB;

        double absolutni_hodnota;


        double uhelSinus;
        double uhelCosinus;

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


            vypocti = new Vypocty(realcisloA, realcisloB, imagcisloA, imagcisloB, znaminkoA, znaminkoB);

            if (parsoval == false)
            {
                prubeh_a_vysledek.Text = "a = ";
            }
            else
            {

                absolutni_hodnota = vypocti.Absolut_hodnotaG();

                uhelCosinus = vypocti.Cosinus();
                uhelCosinus = vypocti.Cosdoradiana();
                uhelCosinus = vypocti.CosDoUhlu();

                uhelSinus = vypocti.Sinus();
                uhelSinus = vypocti.SinRadian();
                uhelSinus = vypocti.SinDoUhlu();



                prubeh_a_vysledek.Text = "a = " + Math.Round(absolutni_hodnota, 1) + " * ( cos " + vypocti.Kvadranty() + "° + i sin " + vypocti.Kvadranty() + "°)";

                //MessageBox.Show(vypocti.Absolut_hodnotaG() + "\n" + vypocti.Cosinus() + "\n" + vypocti.Sinus() + "\n" + vypocti.Cosdoradiana() + "\n" + vypocti.SinRadian() + "\n" + vypocti.CosDoUhlu() + "\n" + vypocti.SinDoUhlu() + "\n" + vypocti.Kvadranty());
            }
        }

        private void pustup_Click(object sender, EventArgs e)
        {
            if (prubeh_a_vysledek.Text == "a = ")
            {
                MessageBox.Show("Musíš zadat hodnoty než budeš chtít zobrazit řešení", "POZOR");
            }
            else
            {
                MessageBox.Show("Tady je to trochu složitější, začneme tím, že si uděláme Absolutní hodnotu, která se vypočítá: \n" + "√(" + realcisloA + "² +" + imagcisloA + "²) \n" + "Dále vydělíme obě zadaná čísla s vypočítanou absolutní hodnotou " + realcisloA + " / " + vypocti.Absolut_hodnotaG() + " + " + imagcisloA + " / " + vypocti.Absolut_hodnotaG() + "\n" + "Máme vypočítaný sinus a cosinus, teď je musíme jen přvést správně na stupně i s kvadranty");
            }
        }
    }
}
