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
        private string equipment;
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
        public string Equipment
        {
            get { return equipment; }
            set { equipment = value; }

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
        //All Characters can equip weapon and armor
        public virtual void EquipWeapon()
        {
            Console.WriteLine("Weapon equiped");
        }
        public virtual void EquipArmor()
        {
            Console.WriteLine("Armor equiped");
        }
        public virtual void LevelUp()
        {
            
        }

    }
}
