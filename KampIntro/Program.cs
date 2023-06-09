using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = {1.13,1.44,1.55,2.01};

            double maxNumbers = 0;
            double totalNumbers = 0;

            foreach (var number in numbers)
            {
                Console.WriteLine(number);

                if (number > maxNumbers)
                {
                    maxNumbers = number;
                    totalNumbers = totalNumbers + number;
                }
            }
            Console.WriteLine("En Buyuk Sayi  : " + maxNumbers);
            Console.WriteLine("Toplam sayi : " + totalNumbers);

          
        }
    }
}
