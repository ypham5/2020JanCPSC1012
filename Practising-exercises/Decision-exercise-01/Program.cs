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
            if (number == 0)
            {
                Console.WriteLine($"Your number {number} is zero");
            }
            else
            {
                if (number>0)
                {
                Console.WriteLine($"Your number {number} is possitive");
                }
                else
                {
                Console.WriteLine($"Your number {number} is negative");
                }
            }
            Console.ReadLine();
            //Exercise-02
            string inputAge, msg;
            double age;
            Console.Write("Enter your age:");
            inputAge = Console.ReadLine();
            age = double.Parse(inputAge);

            if (age < 7)
            {
                msg = "Your admission fee is Child Free";
            }
            else if ( age < 18)
            {
                msg = "Your admission fee is Student $9.80";
            }
            else if (age < 55)
            {
                msg = "Your admission fee is Adult $11.35";
            }
            else
            {
                msg = "Your admission fee is Senior $10.00";
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
            else if  (mark <= 69)
            {
                grademsg = "Your Grade is D";
            }
            else if (mark <= 79)
            {
                grademsg = "Your Grade is C";
            }
            else if (mark <= 89)
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
            double Income;
            decimal taxAmount;
            Console.Write("Enter your taxable income:");
            inputIncome = Console.ReadLine();
            Income = double.Parse(inputIncome);
            const decimal FIVEPERCENTS = 0.05m;
            const decimal SEVENPERCENTS = 0.07m;
            const decimal NINEPERCENTS = 0.09m;
             //using column aligned output 
            //the syntax for formatting {variable, columnsize:formatstring}
            //variable is the data to output 
            //columnsize is the number of character spacing to be used for
            //  the column 
            //positive columnsize is right aligned
            //negative columnsize is left aligned
            //formatstring is your string format 
            //put out the tax table as a column formatted table
            //using a \t character will give columns depending on the length
            //of your output string (inconsistent)
            Console.WriteLine("Taxable Income \t Tax Calculation");
            Console.WriteLine("Up to $50000 \t $0+5% amount over 0");
            Console.WriteLine("Up to $100000 \t $2500+7% amount over $50000");
            Console.WriteLine("$100000 and over \t $6000+9% amount over $100000");
            if ( Income <= 50000)
            {
                //taxAmount is decimal
                //Earnings is a double
                //the compile does not like a mixture
                //solution: a) make Earnings a decimal
                //          b) make everything a double
                //          c) cast the Earnings temporarily to a decimal ****
                //you can use the # sign as a digit placeholder in your format
                //the # sign is ise as "if digit space needed, use it"
                taxAmount = ((decimal)Income)*FIVEPERCENTS;
            }
           
            else if (Income <= 100000)
            {
                taxAmount = 2500.00m + (decimal)(Income-50000)*SEVENPERCENTS;
            }
            else
            {
                taxAmount = 6000.00m + (decimal)(Income-100000)*NINEPERCENTS;
            }
            //dollar amounts can be done with 
            // a) formatting using 0.00 (without $) or $0.00 (with $)
            // b) a small c (currency) will have an automatic $
            Console.WriteLine($"Earning: {Income:$#,##0.00}. Taxes {taxAmount:$0.00}");
            //output using column printing 
            Console.WriteLine("{0,13} {1,15}","Earnings:","Taxes");
            Console.WriteLine($"{Income,13:$#,###.00} {taxAmount,15:c}");
            Console.WriteLine("\n");
            Console.WriteLine($"Earning: {Income:c}. Your income tax is {taxAmount:c}");
            Console.ReadLine();
        }
    }
}
