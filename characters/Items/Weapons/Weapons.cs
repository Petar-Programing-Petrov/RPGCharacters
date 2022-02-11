using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items.Weapons
{
    abstract class Weapons: Items
    {
        //All weapons will have this fields
        private string weaponType;
        private int damage;
        private double damagePerSecccond;


        //Here we set and get the properties of the weapons 
        public double DamagePerSeccond 
        {
            get { return damagePerSecccond; }
            set { damagePerSecccond = value; } 
        }
        public int Damage 
        {
            get { return damage; }
            set { damage = value; } 
        }
        public string WeaponType 
        {
            get { return weaponType;}
            set { weaponType = value; } 
        }
    }
}
