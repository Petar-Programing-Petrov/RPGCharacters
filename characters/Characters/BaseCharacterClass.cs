using characters.Items;
using characters.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    abstract class BaseCharacterClass
    {
        //All Characters will have this fields        
        private string characterClass;
        private Dictionary<Item, Weapon> characterEquipment;
        private string armor;
        private string weapon;

        //Stats or the so called primary atributes
        private int strength;
        private int dexterity;
        private int intelligence;


        //Using getters and setters so we can set or get this information for all characters        
        public string CharacterClass
        {
            get { return characterClass; }
            set { characterClass = value; }

        }
        public string CharacterEquipment
        {
            get { return characterEquipment; }
            set { characterEquipment = value; }

        }
        
        public string Armor
        {
            get { return armor; }
            set { armor = value; }
        }
        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
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


        //All Characters can equip weapon, equip armor, level up. So we make the methods virtual that way we can customise them for each character
        //Need to pass Item 
        public virtual void EquipItem()
        {
            //Need to get item properties and add them to the character Primary atributes and also put them in the characterEquipment
            Console.WriteLine("Armor equiped");
        }
        //Using a overload method to equip Items
        public virtual void EquipItem()
        {
            //Need to get item properties and add them to the character Primary atributes and also put them in the characterEquipment
            Console.WriteLine("Armor equiped");
        }
        public virtual void LevelUp()
        {
            
        }

    }
}
