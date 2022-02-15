using characters.Items.Armor;
using characters.Items.Weapons;
using System.Collections.Generic;
using static characters.Items.Armor.Armor;
using static characters.Items.Item;
using static characters.Items.Weapons.Weapon;

namespace characters
{
    public abstract class BaseCharacterClass 
    {
        public BaseCharacterClass(string name)
        {
            this.CharacterName = name;
            this.CharacterLevel = 1;
        }
        //All Characters will have this fields
        
        private string characterName;
        private int characterLevel;               
        private string characterClass;      
        private int strength;      
        private int dexterity;      
        private int intelligence;
        private PrimaryAttributes primaryAttributes;
        private Dictionary<Slot, TypeOfWeapons> weaponInventory = new Dictionary<Slot, TypeOfWeapons>();
        private Dictionary<Slot, TypeOfArmor> armorInventory = new Dictionary<Slot, TypeOfArmor>();


        //Using getters and setters so we can set or get this information for all characters                                           
        public string CharacterName { get => characterName; set => characterName = value; }
        public int CharacterLevel { get => characterLevel; set => characterLevel = value; }

        public string CharacterClass { get => characterClass; set => characterClass = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }              
        public Dictionary<Slot, TypeOfWeapons> WeaponInventory { get => weaponInventory; set => weaponInventory = value; }
        public Dictionary<Slot, TypeOfArmor> ArmorInventory { get => armorInventory; set => armorInventory = value; }
        public PrimaryAttributes PrimaryAttributes { get => primaryAttributes; set => primaryAttributes = value; }

        //All Characters can equip weapon, equip armor, level up. So we make the methods virtual that way we can customise them for each character        
        /// <summary>
        /// Method takes weapon and try to store it in character's storage.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns>True if the weapon is the correct one or False and throws exception if not</returns>
        public abstract bool EquipWeapon( Weapon weapon);                      
        /// <summary>
        /// Method used to levelup the character 
        /// </summary>
        public abstract void LevelUp();
        public abstract bool EquipArmor(Armor armor);
        public abstract void BaseStats();
        public abstract void TotalStats();
       

    }
}
