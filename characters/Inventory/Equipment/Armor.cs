using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items.Armor
{
    public class Armor : Item 
    {
        private PrimaryAttributes primaryAttributes;
        private TypeOfArmor typeOfArmor;
        public enum TypeOfArmor
        {
            CLOTH,
            LEATHER,
            MAIL,
            PLATE
        }
        public TypeOfArmor ArmorType
        {
            get { return typeOfArmor; }
            set { typeOfArmor = value; }
        }
        public PrimaryAttributes PrimaryAttributes { get => primaryAttributes; set => primaryAttributes = value; }
    }
}
