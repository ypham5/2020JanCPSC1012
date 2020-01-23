using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision1
{
    class Program
    {
        static void Main(string[] args)
        {   //int first;        declare and default to 0
            //int second;       declare and default to 0
            //in highest = -99; declare and set to -99
            int first, second, highest = 0;
            string message;
            string inputValue; //declear and default to null

            Console.Write("Enter first number:\t");
            inputValue = Console.ReadLine();
            if ( !int.TryParse(inputValue, out first))
            {
                Console.WriteLine("You did not enter a number. You entered a character. The number will set to 0 for you");
            }

            //reuse, inputValue because the previous contents
            //  of inputValue has been store somewhere
            Console.Write("Enter second number:\t");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if (first > second)
            {
                //true path coding block        
                //the codition on the if statement is true
                highest = first;
                message = "first";
            }
            else
            {
                //false path coding block
                //the codition on the if statement is false
                highest = second;
                message = "second";
            }//eof
            Console.WriteLine($"First = {first}, Second = {second}" + $", the {message} number entered had the higher value: {highest}");
            Console.ReadKey();
        }//eom
    }//eoc
}//eon
