using Microsoft.Win32; //required for  OpenFileDialog browsing file
using System;
using System.Collections.Generic;
using System.IO;    //required to do file i/o
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
   
    class Program
    { 
        //this required for your code when using OpenFileDialog
        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";
            //the file will be in the same location 
            //you can prompt for the file name 

            //location 
            //setup the path name 
            //string FolderPath = @"c:\Users\ypham5.NAIT\Documents\GitHub\2020JanCPSC1012\";
          
            //use methods within the soflware to access the general special folders 
            // of your Windows file system
            //Documents, Downloads, Pictures, Music

            //this GetFolderPath will return C:\Users\xxxxx\the special foldername
            //for the following statement C:\Users\ypham5.NAIT\Documents
            //string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //now, you must add any additional path structure to get to the specific 
            //  folder within the special folder
            //string FolderPath = specialpathname + @"\GitHub\2020JanCPSC1012\";
            //**************************

            //I will assume that the require file will always be found at the 
            //  root of the course class repository
            /*Console.Write("Enter the file name ex myfile.txt\t");
            string FileName = Console.ReadLine();

            Full_Path_File_Name = FolderPath + FileName;*/
            //**************************
            //Is there a way to browse for a file
            //yes, you call the OpenFileDiaLog
            //this is the dialog open  that you can see on your system
            //when you go browsing for a file within an application
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            //setup for reading a file
            //a string variable is required to received the data 
            //  from the file.
            //the string will be filled with one row from your file
            //  on each file read.
            string readValue = "";

            //use a varaible to count the rows in the file (optional)
            int counter = 0;

            //include what is referred to as "User Friendly error handling"
            //this is your try/catch/finally structure
            //the  finally portion is ONLY needed if you need to close a 
            // conncetion to a data source
            StreamReader reader = null;
            try
            {
                //in the try is the code you will attempt to execute
                //if an error happens during the execution of the code 
                // an Exception is thrown by the system
                // any Exeption thrown by the system is passed to the
                //Catch{} coding block for processing

                //to test the try/catch I wi;; introduce a BAD path name
                //Full_Path_File_Name = @"c:\Users\ypham5.NAIT\Documents\GitHub\2020JanCPSC1012\bob.txt";


            //add the .Net Framework class that contains the code that 
            // will do the read of the file.

                //the require I/O class for reading is StreamReader located 
                // in the namespace System.IO
                //tO ATTACH THE READER TO THE FILE, YOU NEED TO PASS THE 
                // full path file name (fully qualified file name)
                // an argument to the class while it is being created
                //the reader is refer to as an instance of the class 
                //the instace is physical created when the new command is 
                // used in conjuction with class name.
                reader = new StreamReader(Full_Path_File_Name);

            //gets a single row of the file
            readValue = reader.ReadLine();

            //if your line that was "read" is null, you have reach the
            // end of the file (eof)
            while(readValue != null) //stop when you reach the end of the file
            {
                counter++;
                Console.WriteLine($"File Line {counter} has a value of {readValue}\n");
                //get the next line
                readValue = reader.ReadLine();
            }

            } //eof try
            catch(Exception ex)
            {
                // .Message holds the error that occured during the processing 
                //      of the code in your try{...}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                //this is used if you need to close a data source such as an open file
                reader.Close();
            }
            Console.ReadKey();

        }
    }
}
