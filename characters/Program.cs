using System;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarriorClass myWarrioir = new WarriorClass();
            MageClass myMage = new MageClass();

            Console.WriteLine(myMage.CharacterClass); 
            Console.WriteLine(myWarrioir.CharacterClass);

            myMage.EquipItem();
            myWarrioir.EquipItem();
            
           
        }

    }
}
