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
            
            MageClass myMage = new MageClass("Pesho");




            Weapon testWand = new Weapon()
            {
                ItemName = "Common axe",
                ItemSlot = Slot.WEAPON,
                WeaponType = TypeOfWeapons.WAND,



            };
                
            myMage.EquipWeapon(testWand);
            
            
        }

    }
}
