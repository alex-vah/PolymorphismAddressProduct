using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Product:Base
    {
        public Product()
        {

        }
        
        public decimal CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }


        
    }
}
