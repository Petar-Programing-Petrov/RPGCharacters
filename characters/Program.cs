using characters.Items.Weapons;
using characters.Items;
using System;
using static characters.Items.Item;
using static characters.Items.Weapons.Weapon;
using characters.Inventory.Equipment;
using characters.Items.Armor;
using static characters.Items.Armor.Armor;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MageClass mage = new MageClass("Gandalf");
            Console.WriteLine(mage.CharacterStats());
            WarriorClass warrior = new WarriorClass("Rambo");
            WarriorClass warriorWithWeapon = new WarriorClass("Goro");
            Console.WriteLine(warrior.CharacterStats());
            RogueClass rogue = new RogueClass("Gustav");
            Console.WriteLine(rogue.CharacterStats());


        }

    }
}
