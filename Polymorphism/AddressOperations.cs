using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class AddressOperations
    {
        Address address = new Address();
        public bool Save(Address address)
        {
            bool success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
