using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transactions transactions = new Transactions();
            transactions.Addition(3,7);
            transactions.Subtraction(95,28);
        }
    }
}
