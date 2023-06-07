using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Kurslar kurs1 = new Kurslar();
            kurs1.KursAdi = "c# Kursu";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.izlenmeOrani = 88;

            Kurslar kurs2 = new Kurslar();
            kurs2.KursAdi = "Java Kursu";
            kurs2.Egitmen = "Serhat Akar";
            kurs2.izlenmeOrani = 58;

            Kurslar kurs3 = new Kurslar();
            kurs3.KursAdi = "Python Kursu";
            kurs3.Egitmen = "Samet Karadeniz";
            kurs3.izlenmeOrani = 68;

            Kurslar[] kurs = new Kurslar[] { kurs1, kurs2, kurs3 };

            foreach (var kurslar in kurs)
            {
                Console.WriteLine(kurslar.KursAdi + " : " + kurslar.Egitmen + " / izlenme Orani : " + 
                    kurslar.izlenmeOrani);
            }
        }


        class Kurslar
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int izlenmeOrani { get; set; }
        }
    }
}
