using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! " + product.Id + " : " + product.Name 
                + " : " + product.Description + " : " + product.Price 
                + " TL : " + " Stok " + product.Stock );
        }              
    }

    


}
