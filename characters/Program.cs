using characters.Items.Weapons;
using characters.Items;
using System;
using static characters.Items.Item;
using static characters.Items.Weapons.Weapon;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarriorClass myWarrioir = new WarriorClass("Gosho");
            MageClass myMage = new MageClass("Pesho");            
            
            
            myWarrioir.EquipItem();

            Weapon testWand = new Weapon(7,1.1)
            {
                ItemName = "Common axe",
                ItemSlot = Slot.Weapon,
                WeaponType = TypeOfWeapons.Wand,
                
                
            };
            
            myMage.EquipItem(testWand);
            myMage.EquipItem(testWand);
            
        }

    }
}
