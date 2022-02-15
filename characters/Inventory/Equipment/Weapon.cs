using characters.Inventory.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items.Weapons
{
    public class Weapon : Item
    {
        private WeaponAttributes weaponAttributes;
        private TypeOfWeapons typeofWeapons;
        public Weapon()
        {            
            ItemLevel = 1;            
        }              
        //We list the available options 
        public enum TypeOfWeapons
        {
            AXE,
            BOW,
            DAGGER,
            HAMMER,
            STAFF,
            SWORD,
            WAND
        }
        public TypeOfWeapons WeaponType
        {
            get { return typeofWeapons; }
            set { typeofWeapons = value; }
        }
        public WeaponAttributes WeaponAttributes { get => weaponAttributes; set => weaponAttributes = value; }
        /// <summary>
        /// Takes the weapon attributes from class WeaponAttributes
        /// </summary>
        /// <returns>A double representing the damage per seccond depending on weapon atributes</returns>
        public double getDPS(WeaponAttributes weaponAttributes)
        {
            
            double dps = weaponAttributes.Damage * weaponAttributes.AttackSpeed;
            //needs to return a double of the DPS (Damage * Attack speed)
            return dps; // Example
        }
    }
}
