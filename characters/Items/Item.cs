using characters.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items
{
    abstract class Item
    {
        private string itemName;
        private string itemLevel;
        private string requiredLevel;
        private Slot slot;
        private string itemSlot;
        


        //Items affect our character Primary Atributes
        private int strength;
        private int dexterity;
        private int intelligence;

        //We have two types of Items : Armor and Weapons so we create an enum and then with propertie we set or get the itemType        
        public enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon
        }

        public Slot ItemSlot
        { 
            get { return slot; }
            set { slot = value; }
        }
        
        //We provide properties to acces the items
        public string ItemName 
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public string EquipToSlot 
        {
            get { return itemSlot; }
            set { itemSlot = value; } 
        }
        public string ItemLevel 
        {
            get { return itemLevel; }
            set { itemLevel = value; } 
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
