using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logical conditions are two or more conditions 
            //  separated by a logic operation
            //relative operator 
            // > >= < <= == !=
            // operand operrator operand
            // high > low
            //logical operators 
            // || (or) && (and) ! (not)

            int Age = 6;
            if(Age < 4)
            {
                Console.WriteLine("Too Young");
            }
            else if (Age > 14)
                {
                Console.WriteLine("Too Old");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
            //but what about using logical operators
            //Note the operand is repeated for each relative test condition
            //one does NOT know if the age is less than or greater than 
            // (Age<4 || > 14) is incorrect syntax
            if (Age < 4 || Age > 14)
            {
                Console.WriteLine("Sorry you are not in the age bracket for the league");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
            //Truth Table 
            // condition or and
            //  T T      T  T
            //  T F      T  F
            //  F T      T  F
            //  F F      F  F
            
            //sumary && is only true if BOTH relative conditions are True
            // || is only false if BOTH realative conditions are False
            if ( Age >=4 && Age <= 14)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Sorry you are not in the age bracket for the league");
            }
        }
    }
}
