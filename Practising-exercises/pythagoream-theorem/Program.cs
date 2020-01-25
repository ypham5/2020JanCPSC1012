using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pythagoream_theorem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problem
                * find hypotenuse of the right triangle from height and base*/
            //input the height and base
            //output the hypotenuse
            //expression: hypo = sqrt(base*base)+(height*height))
            /*expectation:
             * check 3 4 = 5
             * check 6 8 = 10
             * check 16 17 = 23.345*/
            Console.Write("Enter the value of the base:\n");
            string inputBase = Console.ReadLine();
            double baseValue = double.Parse(inputBase);

            Console.Write("Enter the value of the height:\t");
            string inputHeight = Console.ReadLine();
            double heightValue = double.Parse(inputHeight);

            double hypo = Math.Sqrt(baseValue * baseValue + heightValue * heightValue);
            Console.WriteLine($"The hypotenuse of the right triangle which has height ({heightValue}) and base ({baseValue}) is {hypo}");
            Console.ReadLine();
        }
    }
}
