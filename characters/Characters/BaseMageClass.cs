using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class BaseMageClass : BaseCharacterClass
    {
        //The Mage starts with level 1 atributes and the character class is set to "Mage".
        public void MageClass()
        {
            CharacterClass = "Mage";
            Strength = 1;
            Dexterity = 1;
            Intelligence = 8;
        }
        //When the Mage level's up he gains for every level up +1 Strength, +1 Dexternity and +5 Intelligence
        private void levelUp()
        {
            Console.WriteLine("Mage leveled up!");
            this.Strength += 1;
            this.Dexterity += 1;
            this.Intelligence += 5;
        }
    }
}
