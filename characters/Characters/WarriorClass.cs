using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class WarriorClass : BaseCharacterClass
    {
        //The Warrior starts on 1st lvl with the Character class named "Rogue" 5 Strenght, 2 Dexterity, 1 Intelligence
        public  WarriorClass()

        {
            CharacterClass = "Warrior";
            Strength = 5;
            Dexterity = 2;
            Intelligence = 1;
        }
        //When the Rogue level's up he gains for every level up +1 Strength, +4 Dexternity and +1 Intelligence
        public override void LevelUp()
        {
            Console.WriteLine("Mage leveled up!");
            this.Strength += 3;
            this.Dexterity += 2;
            this.Intelligence += 1;
        }
    }
}
