using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, remainder = 0;
            Console.Write("Year:");
            string inputYear = Console.ReadLine();
            year = int.Parse(inputYear);
            remainder = year % 6;
            switch (remainder)
            {
                case 0:
                    {
                        Console.WriteLine("a");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("b");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("c");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("d");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("e");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("f");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
