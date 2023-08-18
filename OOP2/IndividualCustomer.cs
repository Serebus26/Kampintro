using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{ //Bireysel-GercekMusteri
    internal class IndividualCustomer: Customer
    {      
        public string TcNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
