using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Inventory.Equipment
{
    public class WeaponAttributes
    {
        private double attackSpeed;
        private int damage;        
        
        public double AttackSpeed
        {
            get { return attackSpeed; }
            set { attackSpeed = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
       
    }
}
