using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of my Accessment class 
            Assessment myInstance = new Assessment();

            //use the instance
            //which action in property is being used
            //  on the following statement?
            //set (instance is on the "left side" of an assignment
            myInstance.FirstName = "yen";
            myInstance.LastName = "pham";
            myInstance.AssessmentName = "core portfolio 5";
            myInstance.Mark = 99.9;
            //static or instance
            //static using the class name WITHOUT creating the class
            Console.WriteLine($"First name: {myInstance.FirstName}, Last name: {myInstance.LastName}" + $"Assessment {myInstance.AssessmentName}, Mark: {myInstance.Mark}" + $"Comment:{myInstance.Comment}");
        }
    }
}
