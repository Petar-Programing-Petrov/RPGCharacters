using System;
using System.Linq;

namespace Exists_a_Number_Higher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the nuber to check in array of numbers");
            int num = 0;
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Empty entries are not allowed!");
                return;
            }            
            Console.WriteLine("Now enter the array numbers separated by space");

            //Here we take the input numbers separated by space and comma removing then we parse them to int and 
            int[] input = Console.ReadLine()                
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Calling the method
            existsHigher(num, input);
        }
        static void existsHigher(int num, int[] inputArr)
        {
            bool isTrue = false;
            int biggestNum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                
                if(inputArr[i] > biggestNum)
                {
                    biggestNum = inputArr[i];
                }
                if (biggestNum >= num )
                {
                    isTrue = true;
                }
                else if (biggestNum < num)
                {
                    isTrue = false;
                }                
            }
            Console.WriteLine("");
            Console.WriteLine($"Is your number bigger: -->  {isTrue}  <--");
        }
    }
}
