using characters.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class WarriorClass : BaseCharacterClass
    {
        //The Warrior starts on 1st lvl with the Character class named "Rogue" 5 Strenght, 2 Dexterity, 1 Intelligence
        public  WarriorClass(string name) : base(name)
        {
            CharacterClass = "Warrior";
            Strength = 5;
            Dexterity = 2;
            Intelligence = 1;
            CharacterLevel = 1;
        }
        //When the Rogue level's up he gains for every level up +1 Strength, +4 Dexternity and +1 Intelligence

        public override void EquipItem()
        {
            Console.WriteLine("Armor goes here");
        }
        public override void EquipItem(Weapon weaponItem)
        {
            if (weaponItem.WeaponType == Weapon.TypeOfWeapons.Axe || weaponItem.WeaponType == Weapon.TypeOfWeapons.Hammer || weaponItem.WeaponType == Weapon.TypeOfWeapons.Sword)
            {
                try
                {
                    CharacterEquipment[0] = weaponItem;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Weapon Slot is in use");
                    throw;
                }
                catch (Exception)
                {
                    Console.WriteLine($"{CharacterClass} can't equip this item");
                    throw;
                }

                Console.WriteLine($"{CharacterClass} equiped a {weaponItem.WeaponType}");
            }
            else
            {
                Console.WriteLine($"{CharacterClass} can only equip Wand or Staff as a weapon!");
            }

        }
        public override void LevelUp()
        {
            Console.WriteLine("Mage leveled up!");
            this.Strength += 3;
            this.Dexterity += 2;
            this.Intelligence += 1;
        }
        public override void LevelUp(int level)
        {
            Console.WriteLine("Mage leveled up!");
            this.Strength += 3;
            this.Dexterity += 2;
            this.Intelligence += 1;
        }
    }
}
