using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplexni_cisla
{
    class Vypocty
    {

        private double realcisloA;
        private double realcisloB;
        private double imagcisloA;
        private double imagcisloB;

        private string znaminkoA;
        private string znaminkoB;

        private double sinus;
        private double cosinus;
        private double abs_hodnota;

        public Vypocty(double realcisloA, double realcisloB, double imagcisloA, double imagcisloB,string znaminkoA,string znaminkoB)
        {
            this.realcisloA = realcisloA;
            this.realcisloB = realcisloB;
            this.imagcisloA = imagcisloA;
            this.imagcisloB = imagcisloB;
            
            this.znaminkoA = znaminkoA;
            this.znaminkoB = znaminkoB;
        }
       
        //Sčítání
        public double VratRealSoucet()
        {
            return realcisloA + realcisloB;
        }

        public string PostupRealScitani()
        {
            return "Reálná čísla: " + realcisloA + " + " + realcisloB + " = " + (realcisloA + realcisloB);
        }

        public string PostupImagScitani()
        {
            return "Imaginární čísla: " + imagcisloA + "i + " + imagcisloB + "i = " + (imagcisloA + imagcisloB) + "i";
        }
        public double VratImagSoucet()
        {
            return imagcisloA + imagcisloB;
        }

        //Odčítání
        public double VratRealOdecet()
        {
            return realcisloA - realcisloB;
        }

        public double VratImagOdecet()
        {
            return imagcisloA - imagcisloB;
        }

        public string PostupRealOdcitani()
        {
            return "Reálná čísla: " + realcisloA + " - " + realcisloB + " = " + (realcisloA - realcisloB);
        }

        public string PostupImagOdcitani()
        {
            return "Imaginární čísla: " + imagcisloA + "i - " + imagcisloB + "i = " + (imagcisloA - imagcisloB) + "i";
        }

        //Násobení
        public string Vynasob()
        {
            string znaminko = " + ";
            if (realcisloA * imagcisloB + imagcisloA * realcisloB < 0)
            {
                znaminko = " - ";
                return realcisloA * realcisloB + znaminko + (realcisloA * imagcisloB + imagcisloA * realcisloB) + "i + " + (imagcisloA * imagcisloB) * -1;
            }
            else
                return realcisloA * realcisloB + " + " + (realcisloA * imagcisloB + imagcisloA * realcisloB) + "i + " + (imagcisloA * imagcisloB) * -1;

            if ((imagcisloA * imagcisloB) * -1 < 0)
            {
                znaminko = " - ";
                return realcisloA * realcisloB + " + " + (realcisloA * imagcisloB + imagcisloA * realcisloB) + "i " + znaminko + (imagcisloA * imagcisloB) * -1;
            }
        }

        public string PostupNasob()
        {
            
            return "a * b =  " + realcisloA + " * " + realcisloB + " + " + realcisloA + " * " + imagcisloB + "i + " + imagcisloA + " * " + realcisloB + "i + (" + imagcisloA + " * " + imagcisloB + ") * -1 =  \n" + realcisloA * realcisloB + " + " + realcisloA * imagcisloB + "i + " + imagcisloA * realcisloB + "i + " + (imagcisloA * imagcisloB) * -1 + " \n(Protože když se dostaneme na i² tak se i² automaticky rovná -1";
        }



        //Absolutní hodnota
        public double Vyhodnot()
        {
            return (float)Math.Sqrt(realcisloA * realcisloA + imagcisloA * imagcisloA);
        }

        public string PostupAHodnota()
        {
            return "Absolutní hodnota za |a| = \n" + "√(" + realcisloA + "² + " + imagcisloA + "²) = " + (realcisloA*realcisloA) + " + " + (imagcisloA * imagcisloA) + "\n = " + (float)Math.Sqrt(realcisloA * realcisloA + imagcisloA * imagcisloA);
        }  
        
        //Převedení na goniometrii
        public double Absolut_hodnotaG()
        {
            return abs_hodnota = (float)Math.Sqrt(realcisloA * realcisloA + imagcisloA * imagcisloA);
        }

        public double Cosinus()
        {
            return realcisloA / abs_hodnota;
        }
        public double Sinus()
        {
            return imagcisloA / abs_hodnota;
        }

        public double Cosdoradiana()
        {
            return cosinus = (double)Math.Acos(Math.Abs(Cosinus()));
        }

        public double SinRadian()
        {
            return sinus = (double)Math.Asin(Math.Abs(Sinus()));
        }
       
        public double CosDoUhlu()
        {
            return cosinus = (int)(cosinus * 180/ Math.PI);
        }

        public double SinDoUhlu()
        {
            return sinus = (int)(sinus * 180 / Math.PI);
        }


        public double Kvadranty()
        {
            if (Math.Round(sinus) > 0 && Math.Round(cosinus) < 0)
            {
                return 180 - cosinus;
            }
            else
                if (Math.Round(sinus) < 0 && Math.Round(cosinus) < 0)
                {
                    return 180 + cosinus;
                }
            else
                if (Math.Round(sinus) < 0 && Math.Round(cosinus) > 0)
                {
                    return 360 - cosinus;
                }
                else
                    return cosinus;
        }



    }

}
