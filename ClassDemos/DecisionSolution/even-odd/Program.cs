using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            const int Two = 2; //this is non changable variable
            string inputNumber;
            Console.Write("Enter the number: ");
            inputNumber = Console.ReadLine();
            number = int.Parse(inputNumber);
            if ((number% Two) == 0)
            {
                Console.WriteLine($"The {number} is even");
            }
            else
            {
                Console.WriteLine($"The {number} is odd");
            }
            Console.ReadKey();
        }
    }
}
