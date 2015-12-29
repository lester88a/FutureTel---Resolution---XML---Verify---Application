using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFileScan
{
    class ReadXMl2
    {
        //local variables
        public static string targetDirectory = "D:\\XML"; //The Fixed XML file Directory
        string[] fileNames = Directory.GetFiles(targetDirectory, "*.xml"); //specify the file type and store them in an array

        //XmlReader[] aReader;
        XmlReader aReader;

        //declare a numberOfRecords variable
        int numberOfRecords;

        //declare a repairIDCount variable
        int repairIDCount = 0;

        //public constructor
        public ReadXMl2()
        {
            //verify which files is the resolution files
            for (int i = 0; i < fileNames.Length; i++)
            {
                Console.WriteLine("--  " + fileNames[i] + "  --");
                if (fileNames[i].Contains("RESOLUTION"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Found: " + fileNames[i]); //show the messages that found the specific files

                    //ReadXML rxml = new ReadXML(fileNames[i]); //call the ReadXML class

                    //assign the specific file location and name to XmlReader
                    aReader  = XmlReader.Create(fileNames[i]);

                }

            
            }  

            //verify the number of records
            aReader.MoveToContent();
            while (aReader.Read())
            {
                //find the specific tag (ervmt:numberOfRecords) of the resolution XML file
                if (aReader.NodeType == XmlNodeType.Element && aReader.Name == "ervmt:numberOfRecords")
                {
                    //assign the specific element value and convert it to an integer
                    string messageType = aReader.ReadString();
                    numberOfRecords = Convert.ToInt32(messageType);

                    //display the number of records
                    Console.WriteLine("The number of records: " + numberOfRecords);
                }

                //find the specific tag (ervmt:repairID) of the resolution XML file
                string repairID =null;
                if (aReader.NodeType == XmlNodeType.Element && aReader.Name == "ervmt:repairID")
                { 
                    //assign the specific element value
                    repairID = aReader.ReadString();

                    //display the number of records
                    Console.WriteLine("The repairID: " + repairID);

                    //count the total of repair IDs
                    repairIDCount++;

                    while (aReader.Read())
                    {
                        //verify the repairResolutionList
                        if (aReader.NodeType == XmlNodeType.Element && aReader.Name == "ervmt:repairResolutionCode")
                        {
                            string repairResolutionCode = aReader.ReadString();
                            if (repairResolutionCode == "")
                            {
                                Console.WriteLine(repairID + " has empty repairResolutionCode!!!");
                            }
                            else
                            {
                                Console.WriteLine(repairResolutionCode);
                            }

                        }
                    }
                    
                } 
            }

            Console.WriteLine("The total of the repairIDs: " + repairIDCount);

            //compare between the numberOfRecords and  total of repairIDs
            if (numberOfRecords == repairIDCount) //if match
            {
                Console.WriteLine("This resolution file Passed");
            }
            else //if not match
            {
                throw new Exception("The number of records did not match the total of repairID\n");
            }


            //verify the repairResolutionList
            

        }
    }
}
