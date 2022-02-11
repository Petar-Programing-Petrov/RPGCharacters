using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items.Armor
{
    abstract class Armor : Items 
    {
        //Constructor 
        public Armor()
        {
            
        }

        //Property
        public int MyProperty { get; set; }

    }
}
