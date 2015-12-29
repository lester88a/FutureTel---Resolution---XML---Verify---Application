using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFileScan
{
    class VerifyResolutionFile
    {
        //local variables
        public static string targetDirectory = "D:\\XML Sample"; //The Fixed XML file Directory
        string[] fileNames = Directory.GetFiles(targetDirectory, "*.xml"); //specify the file type and store them in an array


        //constructor
        public VerifyResolutionFile()
        { 
  
        }

        //method
        public void VerifyResolutionFileMethod()
        { 
            //verify which files is the resolution files
            for (int i = 0; i < fileNames.Length; i++)
            {
                if (fileNames[i].Contains("RESOLUTION"))
                {
                    //show the messages that found the specific files
                    Console.WriteLine("\n\nFound: " + fileNames[i]);
                    Console.WriteLine();

                    //verify VerifyNumberOfRecords
                    VerifyNumberOfRecords vfRecords = new VerifyNumberOfRecords(fileNames[i]);
                    vfRecords.VerifyNumberOfRecordsMethod();
                   
                }
            }

            
        }
    }
}
