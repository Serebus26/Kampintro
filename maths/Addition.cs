using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    class Transactions
    {
        public void Addition(int sayi1, int sayi2)
        {
            int total = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + total);
        }
        public void Subtraction(int sayi1, int sayi2)
        {
            int total = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + total);
        }
    }
}
