using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours =0, cost=0;
            string inputPackage, inputHour, msg="";
            Console.Write("Enter your pagekage:");
            inputPackage = Console.ReadLine();
            switch (inputPackage.ToUpper())
            { case "A":
                    {
                        Console.Write("Enter your using hours:");
                        inputHour = Console.ReadLine();
                        hours = double.Parse(inputHour);
                        if ( hours < 11)
                        {
                            cost = 9.95;
                        }
                        else
                        {
                            cost = 9.95 + 2.00 * (hours - 10);
                        }
                        msg = $"Your bill of package {inputPackage} costs {cost:c}";
                        break;
                    }
                case "B":
                    {
                        Console.Write("Enter your using hours:");
                        inputHour = Console.ReadLine();
                        hours = double.Parse(inputHour);
                        if (hours < 21)
                        {
                            cost = 13.95;
                        }
                        else
                        {
                            cost = 13.95 + 1.00 * (hours - 20);
                        }
                        msg = $"Your bill of package {inputPackage} costs {cost:c}";
                        break;
                    }
                case "C":
                    {
                        cost = 19.95;
                        msg = $"Your bill of package {inputPackage} costs {cost:c}";
                        break;
                    }
                default:
                    {
                        Console.Write("Entered Invalid package");
                        break;
                    }
            }
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
