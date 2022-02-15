//using characters.Items.Weapons;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace characters
//{
//    public class RangerClass : BaseCharacterClass
//    {
//        //The Ranger starts with 1st lvl atributes and the character class is set to Ranger
//        public RangerClass(string name) : base(name)
//        {
//            CharacterName = name;   
//            CharacterClass = "Ranger";
//            Strength = 1;
//            Dexterity = 7;
//            Intelligence = 1;
//            CharacterLevel = 1;
//        }
//        //When the Ranger level's up he gains for every level up +1 Strength, +5 Dexternity and +1 Intelligence
//        public override void EquipItem()
//        {
//            Console.WriteLine("Armor goes here");
//        }
//        public override void EquipItem(Weapon weaponItem)
//        {
//            if (weaponItem.WeaponType == Weapon.TypeOfWeapons.BOW)
//            {
//                try
//                {
//                    CharacterEquipment[0] = weaponItem;
//                }
//                catch (IndexOutOfRangeException)
//                {
//                    Console.WriteLine("Weapon Slot is in use");
//                    throw;
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine($"{CharacterClass} can't equip this item");
//                    throw;
//                }

//                Console.WriteLine($"{CharacterClass} equiped a {weaponItem.WeaponType}");
//            }
//            else
//            {
//                Console.WriteLine($"{CharacterClass} can only equip Wand or Staff as a weapon!");
//            }

//        }
//        public override void LevelUp()
//        {
//            Console.WriteLine("Mage leveled up!");
//            this.Strength += 1;
//            this.Dexterity += 5;
//            this.Intelligence += 1;
//        }
//        public override void BaseStats()
//        {

//        }
//        public override void TotalStats()
//        {

//        }

//    }
//}
