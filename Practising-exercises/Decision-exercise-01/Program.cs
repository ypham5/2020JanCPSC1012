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
            //Exercise-01
            string inputValue;
            double number;
            Console.Write("Enter your number:");
            inputValue = Console.ReadLine();
            number = double.Parse(inputValue);
            if (number>=0)
            {
                Console.WriteLine($"Your number {number} is possitive");
            }
            else
            {
                Console.WriteLine($"Your number {number} is negative");
            }
            Console.ReadLine();
            //Exercise-02
            string inputAge, msg;
            double age;
            Console.Write("Enter your age:");
            inputAge = Console.ReadLine();
            age = double.Parse(inputAge);

            if (age <=6)
            {
                msg = "Free";
            }
            else if ( age >= 7 && age <=17)
            {
                msg = "$9.80";
            }
            else if (age >= 18 && age <= 54)
            {
                msg = "$11.35";
            }
            else
            {
                msg = "$10.00";
            }
            Console.WriteLine(msg);
            Console.ReadLine();
            //Exercise03
            string inputMark, grademsg;
            double mark;
            Console.Write("Enter your Mark:");
            inputMark = Console.ReadLine();
            mark = double.Parse(inputMark);

            if (mark<= 49)
            {
                grademsg = "Your Grade is F";
            }
            else if (mark >= 50 && mark <= 69)
            {
                grademsg = "Your Grade is D";
            }
            else if (mark >= 70 && mark <= 79)
            {
                grademsg = "Your Grade is C";
            }
            else if (mark >= 80 && mark <= 89)
            {
                grademsg = "Your Grade is B";
            }
            else
            {
                grademsg = "Your Grade is A";
            }
            Console.WriteLine(grademsg);
            Console.ReadLine();
            //Exercise04
            string inputIncome;
            double tax, income;
            Console.Write("Enter your taxable income:");
            inputIncome = Console.ReadLine();
            income = double.Parse(inputIncome);

            if ( income <=50000)
            {
                tax = 0 + 5 / 100 * income;
            }
            else if (income <=100000)
            {
                tax = 2500 + 7 / 100 * income;
            }
            else
            {
                tax = 6000 + 9 / 100 * income;
            }
            Console.WriteLine($"Your income tax is ${tax}");
            Console.ReadLine();
        }
    }
}
