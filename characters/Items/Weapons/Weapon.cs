using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items.Weapons
{
    internal class  Weapon : Item
    {
        private double attacksPerSeccond;
        private int baseWeaponDamage;
        private string axes;
        private string bows;
        private string daggers;
        private string hammers;
        private string staffs;
        private string swords;
        private string wands;
        

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
        public string Axes 
        {
            get { return axes; }
            set { axes = value; }
            
        }
        public string Bows
        {
            get { return bows; }
            set { bows = value; }
        }
        public string Dagers
        {
            get { return daggers; }
            set { daggers = value; }
        }
        public  string Hammers 
        { 
            get { return hammers; } 
            set { hammers = value; } 
        }

        public string Staffs { get => staffs; set => staffs = value; }
        public string Swords { get => swords; set => swords = value; }
        public string Wands { get => wands; set => wands = value; }


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
    }
}
