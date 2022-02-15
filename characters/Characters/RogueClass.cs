//using characters.Items.Weapons;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace characters
//{
//    public class RogueClass : BaseCharacterClass
//    {
//        //The Rogue starts on 1st lvl with the Character class named "Rogue" 2 Strenght, 6 Dexterity, 1 Intelligence
//        public RogueClass(string name) : base(name)
//        {
//            CharacterName = name;
//            CharacterClass = "Rogue";
//            Strength = 2;
//            Dexterity = 6;
//            Intelligence = 1;
//            CharacterLevel = 1;

//        }
//        //When the Rogue level's up he gains for every level up +1 Strength, +4 Dexternity and +1 Intelligence
//        public override void EquipItem()
//        {
//            Console.WriteLine("Armor goes here");
//        }
//        public override void EquipItem(Weapon weaponItem)
//        {
//            if (weaponItem.WeaponType == Weapon.TypeOfWeapons.DAGGER || weaponItem.WeaponType == Weapon.TypeOfWeapons.SWORD)
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
//            this.Dexterity += 4;
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
