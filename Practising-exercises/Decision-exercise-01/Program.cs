using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            string inputValue = Console.ReadLine();
            double number = double.Parse(inputValue);
            if (number>=0)
            {
                Console.WriteLine($"Your number {number} is possitive");
            }
            else
            {
                Console.WriteLine($"Your number {number} is negative");
            }
            Console.ReadLine();                                                                     
        }
    }
}
