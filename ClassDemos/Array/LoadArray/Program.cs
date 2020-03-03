using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays are a fixed size collection of a single datatype
            //array names hold an interanal address to the actual physical 
            //  memory location of the array storage area 
            //a single item in the array is called the array element 

            //declearing an array requires knowing the
            //  a) physical size
            //  b) the elements to initialize the array
            //  the number of values specifies the physical array size
            //  each supplied value is place within the array consecutively

            //a) array declared by physical size 
            int[] physicallyDecleared = new int[7];

            //b) the elements to initialize the array 
            int[] diceValue = new int[] { 11, 212, 33, 41, 45, 6 };

            //the physically declared array has an initial default 
            //  value for each element depending on the system default 
            //  value of the array datatype
            int pDSize = physicallyDecleared.Length;
            for (int index =0; index < pDSize; index++)
            {
                Console.WriteLine($"physicallyDeleared array element {index + 1} located at index {index} has a value of {physicallyDecleared[index]}");
            }

            int dVSize = diceValue.Length;
            for (int index = 0; index <dVSize; index++)
            {
                Console.WriteLine($"diceValue array element {index + 1} located at index {index} has a value of {diceValue[index]}");
            }
            Console.ReadKey();
        }
    }
}
