using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFileScan
{
    class VerifyNumberOfRecords
    {
        //call the EmailService
        EmailService es = new EmailService();
        //private instance variables
        private string msgSubject = "";
        private string msgBody = "";

        //declare a file name
        string fileName;

        XmlReader reader;

        //declare a numberOfRecords variable
        int numberOfRecords;

        //declare a repairIDCount variable
        int repairIDCount = 0;

        
        //constructor
        public VerifyNumberOfRecords(string fileName)
        {
            this.fileName = fileName;
            reader = XmlReader.Create(fileName);
        }
        
        //method
        public void VerifyNumberOfRecordsMethod()
        {
            //verify the number of records
            reader.MoveToContent();
            while (reader.Read())
            {
                //find the specific tag (ervmt:numberOfRecords) of the resolution XML file
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:numberOfRecords")
                {
                    //assign the specific element value and convert it to an integer
                    string messageType = reader.ReadString();
                    numberOfRecords = Convert.ToInt32(messageType);

                    //display the number of records
                    Console.WriteLine("The number of records: " + numberOfRecords);
                    
                }

                //find the specific tag (ervmt:repairID) of the resolution XML file
                string repairID = null;
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairID")
                {
                    //assign the specific element value
                    repairID = reader.ReadString();

                    //display the number of records
                    Console.WriteLine("The repairID: " + repairID);

                    //count the total of repair IDs
                    repairIDCount++;

                }
            }

            reader.Close();
            //reader.Dispose();

            Console.WriteLine("The total of the repairIDs: " + repairIDCount);

            //compare between the numberOfRecords and  total of repairIDs
            if (numberOfRecords == repairIDCount) //if match
            {
                Console.WriteLine("This number of records Passed!");

               VerifyResolutionList vfRlist = new VerifyResolutionList();
               vfRlist.VerifyrepairResolutionList(fileName);

            }
            else //if not match
            {
                //throw new Exception("The number of records did not match the total of repairID\n");
                Console.WriteLine("The number of records did not match the total of repairID. Failed!!!\n");

                msgSubject = "Errors in resolution XML file: repairID not match";
                msgBody = "\n The number of records: " + numberOfRecords + ", The total of repairIDs: " + repairIDCount + 
                    ".\n The number of records did not match the total of repairID. Failed!!!\n File Name: " + fileName;
                try
                {
                    //send the error message to email
                    //es.SendEmailMethod(msgSubject, msgBody);

                    //this region part is for moving the error files method
                    #region
                    ResolutionFileLocation rf = new ResolutionFileLocation();
                    MoveFailedFile mv = new MoveFailedFile(fileName, fileName.Remove(0,rf.outboundPath.Length));
                    mv.Move();
                    #endregion

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

    }
}
