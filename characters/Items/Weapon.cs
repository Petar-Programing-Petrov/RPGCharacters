using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items.Weapons
{
    internal class Weapon : Item
    {
        private double attacksPerSeccond;
        private int baseWeaponDamage;
        private TypeOfWeapons typeofWeapons;
        public Weapon(int damage, double attacSpeed)
        {
            baseWeaponDamage = damage;
            attacksPerSeccond = attacSpeed;
        }
        //Here we set and get the properties of the weapons 
        public double AttacksPerSeccond
        {
            get { return attacksPerSeccond; }
            set { attacksPerSeccond = value; }
        }
        public int BaseWeaponDamage
        {
            get { return baseWeaponDamage; }
            set { baseWeaponDamage = value; }
        }

        //We also set the properties for each wepon
        public enum TypeOfWeapons
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }
        public TypeOfWeapons WeaponType
        {
            get { return typeofWeapons; }
            set { typeofWeapons = value; }
        }

        /// <summary>
        /// Getting the DPS of the used weapon
        /// </summary>
        /// <returns>The damage per seccond</returns>
        public double getDPS()
        {
            double dps = this.BaseWeaponDamage * this.AttacksPerSeccond;
            //needs to return a double of the DPS (Damage * Attack speed)
            return dps; // Example
        }
        /// <summary>
        /// Takes the damage and attacSpeed of the weapon and sets them to the actual weapon
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="attacSpeed"></param>
        public void WeaponAtributes(int damage, double attacSpeed)
        {
            this.BaseWeaponDamage = damage;
            this.AttacksPerSeccond = attacSpeed;
        }
    }
}
