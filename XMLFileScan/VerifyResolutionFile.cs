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
        //call ResolutionFileLocation
        ResolutionFileLocation rl = new ResolutionFileLocation();

        //local variables
        //public static string targetDirectory = @"C:\Users\lester\Google Drive\FutureTel\Dec 2015\XML Sample"; //The Fixed XML file Directory
        //string[] fileNames = Directory.GetFiles(targetDirectory, "*.xml"); //specify the file type and store them in an array
        string[] fileNames;
        //constructor
        public VerifyResolutionFile()
        { 
            fileNames = Directory.GetFiles(@rl.outboundPath, "*.xml"); 
            
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



                    //verify the mandatory fields
                    VerityMandatoryFields vfm = new VerityMandatoryFields();
                    if (File.Exists(fileNames[i]))
                    {
                        vfm.VerifyRepairTransactionType(fileNames[i]);
                    }
                    if (File.Exists(fileNames[i]))
                    {
                        vfm.VerifyAscWarrantyCD(fileNames[i]);
                    }
                    if (File.Exists(fileNames[i]))
                    {
                        vfm.VerifyClientDamageCd(fileNames[i]);
                    }
                    if (File.Exists(fileNames[i]))
                    {
                        vfm.VerifyShippingDestinationType(fileNames[i]);
                    }
                    

                    //verify VerifyNumberOfRecords
                    if (File.Exists(fileNames[i]))
                    {
                        VerifyNumberOfRecords vfRecords = new VerifyNumberOfRecords(fileNames[i]);
                        vfRecords.VerifyNumberOfRecordsMethod();
                    }
                    

                   
                }
            } 
        }

      
    }
}
