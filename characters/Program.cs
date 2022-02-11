using System;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseWarriorClass myWarrior = new BaseWarriorClass();
            BaseMageClass myMage = new BaseMageClass();
            BaseCharacterClass myCharacter = new BaseCharacterClass();

            Console.WriteLine(myMage.Dexterity); 
            
        }

    }
}
