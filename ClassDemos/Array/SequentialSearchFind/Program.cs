using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace SequentialSearchFind
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //declare an array of 25 elements
            int[] myArray = new int[25];
            string Full_Path_File_Name = "";
            //integer variable to indicate the "logical size" of the array 
            //the "logical size" refers to the number of elements in the array
            //the decleared size (25) is referred to as the physical size
            int logicalsize = 0;
            int physicalsize = 25;

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readValue = "";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null && logicalsize < physicalsize)
                {
                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;

                    //get the next line
                    readValue = reader.ReadLine();
                }

            } //eof try
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for (int loopcounter = 0; loopcounter < logicalsize; loopcounter++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }


            //Sequential Search
            //is it there
            Console.Write($"Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());

            bool found = false;
            int searchindex = 0;

            //condition expression 
            //  a) continue to look until you looked everything.... stop after looking at all elements
            //  b) continue if not found .....stop if found
            //searchcounter is an index (0 based)
            //logicalsize is a natural count (1 based)
            while (searchindex < logicalsize && !found) 
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found 
                    //stop
                    //searchcounter will be the index of the array location where
                    // the searcharg was first found
                    found = true;
                }
                else
                {
                    //increment to look at the next element in the array
                    searchindex++;
                }
               
            }
             if (found)
                {
                    Console.WriteLine($"{searcharg} was found at index {searchindex}");
                }
             else
                {
                    Console.WriteLine($"{searcharg} was NOT found anywhere in the {logicalsize} array elements");
                }

            //count the number of occirances in the array
            searchindex = 0;
            int foundcount = 0;
            found = false;
            //this could also be coded using a for loop BECAUSE 
            //  you are looking at ALL the elements (actual count)
            //for( int searchindex = 0; searchindex < logicalsize, searchindex++)
            //I Do NOT want to stop when I find the first occurance in the loop
            //Is there another way to terminate the loop instead of using logicalsize?
            //using Length, but without physical size
            while (searchindex < logicalsize)
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found 
                    //stop
                    //searchcounter will be the index of the array location where
                    // the searcharg was first found
                    found = true;
                    foundcount++;
                }

                    searchindex++;

            }
            //if( foundcount > 0) the you would not need the boolean found flag
            if (found)
            {
                Console.WriteLine($"{foundcount} occurances of {searcharg} was found in the array");
            }
            else
            {
                Console.WriteLine($"{searcharg} was NOT found anywhere in the {logicalsize} array elements");
            }
            Console.ReadKey();
        }
    }
}
