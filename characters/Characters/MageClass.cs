using characters.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class MageClass : BaseCharacterClass
    {
        //The Mage starts with level 1 atributes and the character class is set to "Mage".

        public MageClass(string name) : base(name)
        {
            CharacterName = name;
            CharacterClass = "Mage";
            Strength = 1;
            Dexterity = 1;
            Intelligence = 8;
            CharacterLevel = 1;
        }

        //When the Mage level's up he gains for every level up +1 Strength, +1 Dexternity and +5 Intelligence
       
        public override void EquipItem()
        {
            Console.WriteLine("You need to input Item");
        }
        public override void EquipItem(Weapon weaponItem)
        {
            if (weaponItem.WeaponType == Weapon.TypeOfWeapons.Wand || weaponItem.WeaponType == Weapon.TypeOfWeapons.Staff)
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
            Console.WriteLine($"Current Mage {this.CharacterName} is at {this.CharacterLevel}lvl.");
            this.Strength += 1;
            this.Dexterity += 1;
            this.Intelligence += 5;

        }
        public override void LevelUp(int level)
        {
            Console.WriteLine("Mage leveled up!");
            Console.WriteLine($"Current Mage {this.CharacterName} is at {this.CharacterLevel}lvl.");
            this.Strength += 1;
            this.Dexterity += 1;
            this.Intelligence += 5;
        }
    }
}
