using System;

namespace characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Pesho";
            writeLine(characterName);
        }
        public static void  writeLine(string name)
        {
            Console.WriteLine($"your name is {name}");
        }
    }
}
