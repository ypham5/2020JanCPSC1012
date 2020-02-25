using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic menu setup
            //loop: post-loop
            //loop contents
            //      prompt for menu option
            //      switch with case for each option, default is bad menu option
            //      within the case we will simple out a message
            //decide how to terminate your loop
            string menuOption ="";

            do
            {
                //prompts
                Console.WriteLine("Select a option from the following option:");
                Console.WriteLine("A) Do case A");
                Console.WriteLine("B) Do case B");
                Console.WriteLine("C) Do case C");
                Console.WriteLine("X) Exit\n");
                Console.WriteLine("Entry your menu option:\t");
                menuOption = Console.ReadLine();

                switch(menuOption.ToUpper())
                {
                    case "A":
                        {
                            //place any logic to do in case A
                            Even_Or_Odds();
                            break;//the break is part of the key not the method
                        }
                    case "B":
                        {
                            //place the heads or tails game in this case
                            //validate that an H or T was entered, if not repeat query for input
                            //Create a method that holds the actual code for this case
                            //The B case will CALL the metohd to execute
                            //this action is reffered to as the calling satement
                            //calling requires your code to use the method name
                            //your program will branch to the requested method
                            //when the metohd has finished, your program will return
                            //  to the next excutable statement AFTER the method call.

                            Head_Or_Tails_Game();
                            break;
                        }
                    case "C":
                        {
                            //the sum of squares
                            //enter positive integer number (validate)
                            //loop n times where n is the integer number (1 to n)
                            //within the loop your calculation is total += loopnumber * loopnumber
                            //after the loop display your integer number and its sum of squares
                            //entered 4
                            //loop 4 times 1) 1*1 2) 2*2 3) 3*3 4) 4*4 final total = 30
                            Console.WriteLine("Your entered menu option choice of C \n\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine($"Thank you. Come again.\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a varidation for the proper value of a menuOption
                            Console.WriteLine($@"Your menu option choice of {menuOption} is incorrect. Try again." +"\n\n");
                            break;
                        }
                }
            } while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }//eom Main

        //the syntax for a method requires 
        //  accesstype returndatatype MethodName([list of parameters])
        //  {
        //      your method code
        //  } //eom

        //accesstype: public or private
        //            protected, internal, have static reference 

        //returndatatype: if you are returning notihng use the key word void
        //                  Otherwise, return a single value such as int, double, decimal, DataTime ...
        

    //MethodName: continuous string of characters wich will be used within
    //            your program code to reference this coding block
    //            it is best to use a meaningful name

    //[list of parameters] this is a set of local variables that will be used 
    //                     to receive values from the calling statement
    //                     a parameter is a set of datatype variablename
                           // parameters are seperated by using a comma.
    
        static public void  Head_Or_Tails_Game()
        {
            string inputString ="";
            int headcount=1, tailcount=1;
        do {

            do
            {
                    Console.WriteLine("Enter a H (heads) or T (tails) or Q(quit)");
                    inputString = Console.ReadLine();
            }while(!inputString.ToUpper().Equals("H") &&
                    !inputString.ToUpper().Equals("T") &&
                    !inputString.ToUpper().Equals("Q"));
            if (!inputString.ToUpper().Equals("H") || !inputString.ToUpper().Equals("T")) 
                    {
                    //heads or tails
                    if (inputString.ToUpper().Equals("H"))
                        {
                         headcount++;
                         Console.WriteLine($"{inputString} is heads ");
                        }
                    else
                        {
                        tailcount++;
                        Console.WriteLine($"{inputString} is tails ");
                        }
                    }
            else    
                    {
                    //quit
                    if (headcount > tailcount)
                    {
                        Console.WriteLine($"Heads wins over Tails: {headcount} to {tailcount}");
                    }
                    else if(headcount < tailcount)
                    {
                        Console.WriteLine($"Tails wins over Heads: {tailcount} to {headcount}");
                    }
                    }
                    Console.WriteLine("\n\nThank you. Hope you enjoy the game.");                                       
           }while(!inputString.ToUpper().Equals("Q"));
        }//eom
        static public void  Even_Or_Odds()
        {
            int evenNumbers = 0;
            int oddNumbers = 0;
            string inputNumber;
            int number;
            const int TWO = 2;

            int loopCounter = 1;
            while (loopCounter <=7)
            {
                Console.Write("Enter the number: ");
                inputNumber = Console.ReadLine();
                number = int.Parse(inputNumber);
                if ((number % TWO) == 0)
                {
                    //evenNumbers = evenNumbers + 1;
                    evenNumbers++; //running total
                }
                else
                {
                    //oddNumbers = oddNumbers + 1;
                    oddNumbers += 1; //running total
                }//eof

                //increment the loop counter 
                loopCounter++;
            }//eol

            Console.WriteLine($"\nThe even number count is {evenNumbers}");
            Console.WriteLine($"The odd number count is {oddNumbers}\n\n");
        }//eom Even_Or_Odd
    }
}
