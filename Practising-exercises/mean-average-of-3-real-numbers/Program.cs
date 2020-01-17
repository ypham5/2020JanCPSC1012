using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mean_average_of_3_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Problem
             * find mean average of 3 real numbers*/
            //input: number 1, 2, 3
            //output: their mean average
            //expression: (number 1 + number 2 + number 3)/3
            /*expectation:
             * check  (34+35+36)/3=35
             * check  (98+75+54)/3=75.67
             * check  (1230+4454+657)/3= 2113.676*/
            //prompts for 3 real numbers
            //convert string into double
            Console.Write("Enter your first number:\t");
            string input1stnumber = Console.ReadLine();
            double number1= double.Parse(input1stnumber);
            Console.Write("Enter your second number:\t");
            string input2ndnumber = Console.ReadLine();
            double number2= double.Parse(input2ndnumber);
            Console.Write("Enter your third number:\t");
            string input3rdnumber = Console.ReadLine();
            double number3 = double.Parse(input3rdnumber);
            //caculates their mean average
            double meanAverage = (number1 + number2 + number3) / 3;
            Console.WriteLine($"The mean average of {number1}, {number2}, {number3} is {meanAverage:0.00}");
            Console.ReadLine();

            //can I shorten the code with this method?
            Console.Write("Enter your first number:\t");
            double number = double.Parse(Console.ReadLine());
        }
    }
}
