using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ProductOperations
    {
        Product product = new Product();
        public bool Save(Product product)
        {
            bool success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

    }
}
