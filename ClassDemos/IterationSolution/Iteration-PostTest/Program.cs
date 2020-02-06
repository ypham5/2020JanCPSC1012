using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_PostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            const int Two = 2; //this is non changable variable
            string inputNumber, answer="";

            //the loop structure demonstrated in this sample is a Post-test
            //Post-Test is also known as Do Until 
            //Post-Test executes the code ONCE BEFORE the loop condition is tested
            //after the code has executed, the pre-test condition is still for true 
            //if the condition is still true the loop code is re-executed
            //if the condintion is false the loop terminates and execution
            //  continues with the remainder of the program

            do
            {
                //within this coding block you are inside your loop
                //this loop will terminate is answer is not Yy

                //TODO: place your loop logic here
                Console.Write("Enter the number: ");
                inputNumber = Console.ReadLine();
                number = int.Parse(inputNumber);
                if ((number % Two) == 0)
                {
                    Console.WriteLine($"The {number} is even");
                }
                else
                {
                    Console.WriteLine($"The {number} is odd");
                }//eof

                //ask if the user wishes to continue to play the game
                //give the user an opportunity to exit the loop
                Console.Write("\n\nDo you wish to CONTINUE playing the Even or Odd game? ");
                answer = Console.ReadLine();
            } while (answer.ToUpper().Equals("Y"));

                

            Console.Write("\n\nYou terminated the loop with you last answer? ");
            Console.ReadKey();
        }
    }
}
