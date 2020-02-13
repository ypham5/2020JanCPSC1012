using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace head_tail_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            int loopCounter = 1, head = 0, tail = 0;
            while (loopCounter <= 7)
            {
                Console.Write("Enter the H or T: ");
                inputValue = Console.ReadLine();
                switch (inputValue.ToUpper())
                {
                    case "H":
                        {
                            head++;
                            break;
                        }
                    case "T":
                        {
                            tail++;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Entered invalid value");
                            break;
                        }
                }
                loopCounter++;

            }//eol

            Console.WriteLine($"\nThe even number count is {head}");
            Console.WriteLine($"The odd number count is {tail}\n\n");
        }
    }
}

