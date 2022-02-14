using characters.Items.Armor;
using characters.Items.Weapons;
using System.Collections.Generic;

namespace characters
{
    abstract class BaseCharacterClass
    {
        public BaseCharacterClass(string name)
        {
            this.CharacterName = name;
            this.CharacterLevel = 1;
        }
        //All Characters will have this fields
        private Weapon[] characterEquipment = new Weapon[1];
        private string characterName;
        private int characterLevel;
        private double basePrimaryAttributes;
        private double totalPrimaryAttributes;
        private string characterClass;      
        private int strength;      
        private int dexterity;      
        private int intelligence;      


        //Using getters and setters so we can set or get this information for all characters                                           
        public string CharacterName { get => characterName; set => characterName = value; }
        public int CharacterLevel { get => characterLevel; set => characterLevel = value; }
        public double TotalPrimaryAttributes { get => totalPrimaryAttributes; set => totalPrimaryAttributes = value; }      
        public double BasePrimaryAttributes { get => basePrimaryAttributes; set => basePrimaryAttributes = value; }
        public string CharacterClass { get => characterClass; set => characterClass = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        internal Weapon[] CharacterEquipment { get => characterEquipment; set => characterEquipment = value; }










        //All Characters can equip weapon, equip armor, level up. So we make the methods virtual that way we can customise them for each character        

        /// <summary>
        /// Method used to equip items
        /// </summary>
        public abstract void EquipItem();                      
        public abstract void EquipItem(Weapon weaponItem);                      
        /// <summary>
        /// Method used to levelup the character 
        /// </summary>
        public abstract void LevelUp();
        public abstract void LevelUp(int level);
       

    }
}
