using characters.Exceptions;
using characters.Items.Armor;
using characters.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static characters.Items.Item;

namespace characters
{
    public class WarriorClass : BaseCharacterClass
    {
        //The Warrior starts on 1st lvl with the Character class named "Rogue" 5 Strenght, 2 Dexterity, 1 Intelligence
        public WarriorClass(string name) : base(name)
        {
            CharacterClass = "Warrior";            
            CharacterName = name;
            CharacterLevel = 1;            
            PrimaryAttributes.Strength = 5.0;
            PrimaryAttributes.Dexterity = 2.0;
            PrimaryAttributes.Intelligence = 1.0;
        }
        //When the Rogue level's up he gains for every level up +1 Strength, +4 Dexternity and +1 Intelligence

        public override bool EquipWeapon(Weapon weapon)
        {
            try //Try will return TRUE if weapon is the correct type, level and if its equipped on an empty slot for this character.
            {
                //We check if weapon is from the type of weapon for the current character
                if (weapon.WeaponType == Weapon.TypeOfWeapons.AXE || weapon.WeaponType == Weapon.TypeOfWeapons.HAMMER || weapon.WeaponType == Weapon.TypeOfWeapons.SWORD)
                {
                    //Check if trying to equip weapon to the wrong slot 
                    if (weapon.ItemSlot != Slot.WEAPON)
                    {
                        throw new InvalidWeaponException($"{CharacterClass} can't equip weapon in the {weapon.ItemSlot} slot!");
                    }
                    //If the slot is already taken we throw an invalid weapon exception
                    else if (WeaponInventory.ContainsKey(weapon.ItemSlot))
                    {
                        throw new InvalidWeaponException($"{CharacterClass} can only equip one weapon from type Hammer,Sword or Axe for this slot!");
                    }
                    //then we check if the weapon level is lower or equal to charackter beffore equipping it.
                    else if (weapon.ItemLevel <= this.CharacterLevel)
                    {
                        WeaponInventory.Add(weapon.ItemSlot, weapon);
                        Console.WriteLine($"{weapon.ItemName} was added to your {weapon.ItemSlot}");
                        Console.WriteLine($"{CharacterClass} equiped a {weapon.WeaponType}");
                        // we return true for easyer uniTtest
                        return true;
                    }
                    else //if none from the above checked conditions are met, we throw an exception for invalid weapon
                    {
                        throw new InvalidWeaponException("Weapon level is higher than your character's level");
                    }
                }
                else//If the weapon is not the correct type for this character we throw an invalid weapon exception
                {
                    throw new InvalidWeaponException($"{CharacterClass} can't equip this item ");
                }
            }//If an exeption is thrown we catch it and return false for easier unit testing.
            catch (InvalidWeaponException exception)
            {
                Console.WriteLine(exception);
                return false;
            }

        }
        public override bool EquipArmor(Armor armor)
        {
            try //Try will return TRUE if weapon is the correct type, level and if its equipped on an empty slot for this character.
            {
                //We check if armor is from the type of armor for the current character
                if (armor.ArmorType == Armor.TypeOfArmor.MAIL || armor.ArmorType == Armor.TypeOfArmor.PLATE)
                {
                    //Check if trying to equip weapon to the wrong slot 
                    if (armor.ItemSlot == Slot.WEAPON)
                    {
                        throw new InvalidArmorException($"{CharacterClass} can't equip armor in the {armor.ItemSlot} slot!");
                    }
                    //If the slot is already taken we throw an invalid armor exception
                    else if (ArmorInventory.ContainsKey(armor.ItemSlot))
                    {
                        throw new InvalidArmorException($"{CharacterClass} slot is already in use");
                    }
                    //then we check if the weapon level is lower or equal to charackter beffore equipping it.
                    else if (armor.ItemLevel <= this.CharacterLevel)
                    {
                        ArmorInventory.Add(armor.ItemSlot, armor);
                        Console.WriteLine($"{armor.ItemName} was added to your {armor.ItemSlot}");
                        Console.WriteLine($"{CharacterClass} equiped a {armor.ArmorType}");
                        // we return true for easyer uniTtest
                        return true;
                    }
                    else //if none from the above checked conditions are met, we throw an exception for invalid armor level
                    {
                        throw new InvalidArmorException("Armor level is higher than your character's level");
                    }
                }
                else//If the armor is not the correct type for this character we throw an invalid weapon exception
                {
                    throw new InvalidArmorException($"{CharacterClass} can't equip this item ");
                }
            }//If an exeption is thrown we catch it and return false for easier unit testing.
            catch (InvalidArmorException exception)
            {
                Console.WriteLine(exception);
                return false;

            }
        }
        public override void LevelUp()
        {            
            Console.WriteLine("Warrior leveled up!");
            Console.WriteLine($"Current Mage {this.CharacterName} is at {this.CharacterLevel} lvl.");
            PrimaryAttributes.Strength += 3.0;
            PrimaryAttributes.Dexterity += 2.0;
            PrimaryAttributes.Intelligence += 1.0;
            CharacterLevel++;
        }
        public override string BaseStats()
        {
            StringBuilder defaultAttributes = new StringBuilder();
            defaultAttributes.Append($"Character Name: {CharacterName}" +
                $"\nCharacter Level: {CharacterLevel}" +
                $"\nStrength: {PrimaryAttributes.Strength}" +
                $"\nDexterity: { PrimaryAttributes.Dexterity}" +
                $"\nIntelligence: {PrimaryAttributes.Intelligence}");

            return defaultAttributes.ToString();
        }
        public override string CharacterStats()
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
        public override double CharacterDamage()
        {
            double mageBaseDamage = 1;//Base damage as per assignemnt is 1 without weapon
                                      

            //If Character equips armor  we calculate only the damageBonus for the character
            if (ArmorInventory.Count > 0)
            {
                //With armor we check every slot and add the Intelligence to the base damage atribute for mage
                if (ArmorInventory.ContainsKey(Slot.LEGS) == true)
                {
                    PrimaryAttributes.Strength += ArmorInventory[Slot.LEGS].PrimaryAttributes.Strength;
                }
                else if (ArmorInventory.ContainsKey(Slot.HEAD) == true)
                {
                    PrimaryAttributes.Strength += ArmorInventory[Slot.HEAD].PrimaryAttributes.Strength;
                }
                else if (ArmorInventory.ContainsKey(Slot.BODY) == true)
                {
                    PrimaryAttributes.Strength += ArmorInventory[Slot.BODY].PrimaryAttributes.Strength;
                }

            }
            //If Character equips weapon it only affects the delth damage taking in mind we checked if armor is affecting the damageBonus
            if (WeaponInventory.ContainsKey(Slot.WEAPON) == true)
            {
                double weaponDps = WeaponInventory[Slot.WEAPON].getDPS();
                double totalCharacterDamage = weaponDps * (mageBaseDamage + PrimaryAttributes.Strength / 100);
                
                return totalCharacterDamage;
            }

            // No Weapon nor Armor!!! We calculate the base Damage set to 1 as per Assignment instructions in 4.1) under NOTE:, and add the bonus from baseAttributes that depend on level
            else
            {
                double noWeaponDamage = mageBaseDamage * (mageBaseDamage + PrimaryAttributes.Strength / 100);
                return noWeaponDamage;

            }




        }


    }
}
