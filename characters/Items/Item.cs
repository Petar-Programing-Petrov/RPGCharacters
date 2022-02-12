using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items
{
    abstract class Item
    {
        private string name;
        private string equipToSlot;
        private string requiredLevel;
        //Items affect our character Primary Atributes

        private int strength;
        private int dexterity;
        private int intelligence;

        //We have two types of Items : Armor and Weapons so we create an enum and then with propertie we set or get the itemType
        

       


        //We provide properties to acces the 
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string EquipToSlot 
        {
            get { return equipToSlot; }
            set { equipToSlot = value; } 
        }
        public string RequiredLevel 
        {
            get { return requiredLevel; }
            set { requiredLevel = value; } 
        }

        public int Strength        
        {
            get { return strength; }
            set { strength = value; } 
        }
        public int Dexterity 
        {
            get { return dexterity; }
            set { dexterity = value; } 
        }
        public int Intelligence 
        {
            get { return intelligence; }
            set { intelligence = value; } 
        }

    }
}
