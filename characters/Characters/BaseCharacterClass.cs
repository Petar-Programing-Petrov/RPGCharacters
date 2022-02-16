using characters.Items.Armor;
using characters.Items.Weapons;
using System.Collections.Generic;
using System.Text;
using static characters.Items.Armor.Armor;
using static characters.Items.Item;
using static characters.Items.Weapons.Weapon;

namespace characters
{
    /// <summary>
    /// This class takes a string for the character's name
    /// </summary>
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
        private PrimaryAttributes primaryAttributes = new PrimaryAttributes();        
        private Dictionary<Slot, Weapon> weaponInventory = new Dictionary<Slot, Weapon>();
        private Dictionary<Slot, Armor> armorInventory = new Dictionary<Slot, Armor>();


        //Using getters and setters so we can set or get this information for all characters                                           
        public string CharacterName { get => characterName; set => characterName = value; }
        public int CharacterLevel { get => characterLevel; set => characterLevel = value; }

        public string CharacterClass { get => characterClass; set => characterClass = value; }                   
        public Dictionary<Slot, Weapon> WeaponInventory { get => weaponInventory; set => weaponInventory = value; }
        public Dictionary<Slot, Armor> ArmorInventory { get => armorInventory; set => armorInventory = value; }
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
        /// <summary>
        /// Use this method to equip armor
        /// </summary>
        /// <param name="armor"></param>
        /// <returns>Returns true if the armor is the correct type or slot and false with custom exception if not</returns>
        public abstract bool EquipArmor(Armor armor);
        /// <summary>
        /// Calling this method for a character
        /// </summary>
        /// <returns>Returns string with the default created Character attributes</returns>
        public virtual string BaseStats()
        {
            StringBuilder defaultAttributes = new StringBuilder();
            defaultAttributes.Append($"Character Name: {CharacterName}" +
                $"\nCharacter Level: {CharacterLevel}" +
                $"\nStrength: {PrimaryAttributes.Strength}" +
                $"\nDexterity: { PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {PrimaryAttributes.Intelligence}");

            return defaultAttributes.ToString();
        }
        /// <summary>
        /// Calling this methon on characters
        /// </summary>
        /// <returns>Returns a string with the character statistics and damage with or without equipment</returns>
        public virtual string CharacterStats()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Character Name: {CharacterName}" +
                $"\nCharacter Level: {CharacterLevel}" +
                $"\nStrength: {PrimaryAttributes.Strength}" +
                $"\nDexterity: { PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {PrimaryAttributes.Intelligence}" +
                $"\nCharacter Damage: {CharacterDamage()}");
            return result.ToString();
        }
        /// <summary>
        /// This method calculates the character damage with current equipment
        /// </summary>
        /// <returns>The damage in double</returns>
        public abstract double CharacterDamage();
       

    }
}
