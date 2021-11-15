using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Address:Base
    {
        public Address()
        {

        }

        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }


        public override bool Validate()
        {
            bool isValid = true;

            if (PostalCode == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
