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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scitani soucet = new Scitani();

            this.Hide();
            soucet.ShowDialog();
            this.Show();

        }

        private void ödecti_Click(object sender, EventArgs e)
        {
            Odcitani odecet = new Odcitani();

            this.Hide();
            odecet.ShowDialog();
            this.Show();

        }

        private void nasob_Click(object sender, EventArgs e)
        {
            Nasobeni nasobeni = new Nasobeni();

            this.Hide();
            nasobeni.ShowDialog();
            this.Show();
        }

        private void absolut_hodno_Click(object sender, EventArgs e)
        {
            Absoutni_hodnota hodnoty = new Absoutni_hodnota();

            this.Hide();
            hodnoty.ShowDialog();
            this.Show();
        }

        private void sdruzeni_Click(object sender, EventArgs e)
        {
            komplex_sdruzeni komplex = new komplex_sdruzeni();
            this.Hide();
            komplex.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goniometrie goniometrie = new goniometrie();
            this.Hide();
            goniometrie.ShowDialog();
            this.Show();
        }
    }
}