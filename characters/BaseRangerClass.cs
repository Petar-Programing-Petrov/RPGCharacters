using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class BaseRangerClass: BaseCharacterClass
    {
        //The Ranger starts with 1st lvl atributes and the character class is set to Ranger
        public void RangerClass()
        {
            CharacterClass = "Ranger";
            Strength = 1;
            Dexterity = 7;
            Intelligence = 1;
        }
        //When the Ranger level's up he gains for every level up +1 Strength, +5 Dexternity and +1 Intelligence
        private void levelUp()
        {
            Console.WriteLine("Mage leveled up!");
            this.Strength += 1;
            this.Dexterity += 5;
            this.Intelligence += 1;
        }
    }
}
