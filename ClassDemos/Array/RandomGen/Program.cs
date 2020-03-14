using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGen
{
    class Program
    {
        //if declared outside of a method add the keyword static in front
        // of your declaration
        //if declared outside of a method BUT within the class The the 
        //variable is known to ALL methods WITHOUT having to pass
        //the value as a parameter
        //static Random rnd = new Random(); if you wanna random outside must go with static
        static void Main(string[] args)
        {
            //Random is a datatype of class (object)
            //Random is just the definition of the object (decribes the object)
            //Random is NOT a physical instance of the object
            //To get a physical instance of the object use the keyboard new
            //new is used by any object to create an instance of that object 
            //To identify the object instance datatype, add the class name after the keyword new
            //Random is datatype 
            //rnd is the variable name of the object instance
            //new is the command keyword to create an object instance 
            //Random() is the type of object instance new to create
            Random rnd = new Random();
            int[] myArray = new int[10];
            for (int i=0; i<10; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                Console.WriteLine($"index {i} has a value of {myArray[i]}");
            }

            //what is the highish random number generated and the lowest random number generated 
            int highest = 0;
            int lowest = 100;

            int loopCounter = 0;
            while(loopCounter<10)
            {
                if (highest < myArray[loopCounter])
                {
                    highest = myArray[loopCounter];
                }
                if (lowest > myArray[loopCounter])
                {
                    lowest = myArray[loopCounter];
                }
                loopCounter++;
            }
            Console.WriteLine($"highest value is {highest}");
            Console.WriteLine($"lowest value is {lowest}");
        }
        //static void SomeMethod (Random paramRnd) datatype + variable and random is datatype 
    }
}
