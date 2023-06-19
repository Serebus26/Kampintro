using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] name = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);
            //Console.WriteLine(name[3]);
            //name = new string[5];
            //name[4] = "İlker";
            //Console.WriteLine(name[4]);
            //Console.WriteLine(name[0]);
                        
            List<string> name1 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(name1[0]);
            Console.WriteLine(name1[1]);
            Console.WriteLine(name1[2]);
            Console.WriteLine(name1[3]);
            name1.Add("İlker");            
            Console.WriteLine(name1[4]);
            Console.WriteLine(name1[0]);
            Console.WriteLine(name1[1]);


        }
    }
}
