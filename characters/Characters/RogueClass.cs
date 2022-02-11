using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    internal class RogueClass : BaseCharacterClass
    {
        //The Rogue starts on 1st lvl with the Character class named "Rogue" 2 Strenght, 6 Dexterity, 1 Intelligence
        public RogueClass()
        {
            CharacterClass = "Rogue";
            Strength = 2;
            Dexterity = 6;
            Intelligence = 1;
        }
        //When the Rogue level's up he gains for every level up +1 Strength, +4 Dexternity and +1 Intelligence
        public override void LevelUp()
        {
            Console.WriteLine("Mage leveled up!");
            this.Strength += 1;
            this.Dexterity += 4;
            this.Intelligence += 1;
        }
    }
}
