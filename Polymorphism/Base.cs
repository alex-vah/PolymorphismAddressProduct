using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Base
    {
        public bool HasChanges { get; set; }
        public bool IsNew { get; }
        public bool IsValid => Validate();

        public virtual bool Validate()
        {
            if(IsNew)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
