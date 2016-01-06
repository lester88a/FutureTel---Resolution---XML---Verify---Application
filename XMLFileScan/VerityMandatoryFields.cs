using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFileScan
{
    class VerityMandatoryFields
    {
        //call the EmailService
        EmailService es = new EmailService();
        //private instance variables
        private string msgSubject = "";
        private string msgBody = "";

        //constructor
        public VerityMandatoryFields()
        { 
            
        }

        //verify ascWarrantyCd field
        public void VerifyAscWarrantyCD(string fileName)
        {
            XmlReader reader = XmlReader.Create(fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            reader.Close();
            //reader.Dispose();

            //verify the tag
            foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
            {
                try
                {
                    string ascWarrantyCd = e.SelectSingleNode("*[local-name() = 'ascWarrantyCd']").InnerText;
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Missing the ascWarrantyCd tag. Failed!!!");
                    msgSubject = "Errors in resolution XML file: ascWarrantyCd tag";
                    msgBody = "\n Missing the ascWarrantyCd tag. Failed!!!\n File Name: " + fileName;
                    try
                    { 
                        //es.SendEmailMethod(msgSubject, msgBody);

                        if (File.Exists(fileName))
                        {
                            MoveErrorFiles(fileName);
                        }
                        
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            //verify the content
            while (reader.Read())
            {
                string clientDamageCdCon;
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:ascWarrantyCd")
                {
                    clientDamageCdCon = reader.ReadString();
                    if (clientDamageCdCon == "")
                    {
                        Console.WriteLine("The content of ascWarrantyCd tag is empty. Failed!!!\n");
                        msgSubject = "Errors in resolution XML file: ascWarrantyCd content";
                        msgBody = "\n The content of ascWarrantyCd tag is empty. Failed!!!\n File Name: " + fileName;
                        try
                        {
                            //es.SendEmailMethod(msgSubject, msgBody);

                            if (File.Exists(fileName))
                            {
                                MoveErrorFiles(fileName);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }

                }
            }
            reader.Close();
            //reader.Dispose();
        }

        

        //verify clientDamageCd
        public void VerifyClientDamageCd(string fileName)
        {
            XmlReader reader = XmlReader.Create(fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            reader.Close();
            //reader.Dispose();

            //verify the tag
            foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
            {
                try
                {
                    string clientDamageCd = e.SelectSingleNode("*[local-name() = 'clientDamageCd']").InnerText;
                }
                catch (Exception)
                {
                    Console.WriteLine("Missing the clientDamageCd tag. Failed!!!");
                    msgSubject = "Errors in resolution XML file: clientDamageCd tag";
                    msgBody = "\n Missing the clientDamageCd tag. Failed!!!\n File Name: " + fileName;
                    try
                    {
                        //es.SendEmailMethod(msgSubject, msgBody);

                        if (File.Exists(fileName))
                        {
                            MoveErrorFiles(fileName);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            //verify the content
            while (reader.Read())
            {
                string clientDamageCdCon;
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:clientDamageCd")
                {
                    clientDamageCdCon = reader.ReadString();
                    if (clientDamageCdCon == "")
                    {
                        Console.WriteLine("The clientDamageCd is empty. Failed!!!\n");
                        msgSubject = "Errors in resolution XML file: clientDamageCd content";
                        msgBody = "\n The content of clientDamageCd tag is empty. Failed!!!\n File Name: " + fileName;
                        try
                        {
                            //es.SendEmailMethod(msgSubject, msgBody);

                            if (File.Exists(fileName))
                            {
                                MoveErrorFiles(fileName);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }

                }
            }

            reader.Close();
            //reader.Dispose();

        }

        //repairTransactionType
        public void VerifyRepairTransactionType(string fileName)
        {
            XmlReader reader = XmlReader.Create(fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            reader.Close();
            //reader.Dispose();

            //verify the tag
            foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
            {
                try
                {
                    string repairTransactionType = e.SelectSingleNode("*[local-name() = 'repairTransactionType']").InnerText;
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Missing the repairTransactionType tag. Failed!!!");
                    msgSubject = "Errors in resolution XML file: repairTransactionType tag";
                    msgBody = "\n Missing the repairTransactionType tag. Failed!!!\n File Name: " + fileName;
                    try
                    {
                        //es.SendEmailMethod(msgSubject, msgBody);

                        if (File.Exists(fileName))
                        {
                            MoveErrorFiles(fileName);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            //verify the content
            while (reader.Read())
            {
                string repairTransactionTypeCon;
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairTransactionType")
                {
                    repairTransactionTypeCon = reader.ReadString();
                    if (repairTransactionTypeCon == "")
                    {
                        Console.WriteLine("The repairTransactionType is empty. Failed!!!\n");
                        msgSubject = "Errors in resolution XML file: repairTransactionType content";
                        msgBody = "\n The content of repairTransactionType tag is empty. Failed!!!\n File Name: " + fileName;
                        try
                        {
                            //es.SendEmailMethod(msgSubject, msgBody);

                            if (File.Exists(fileName))
                            {
                                MoveErrorFiles(fileName);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }

                }
            }

            reader.Close();
            //reader.Dispose();

        }

        //shippingDestinationType
        public void VerifyShippingDestinationType(string fileName)
        {
            XmlReader reader = XmlReader.Create(fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            reader.Close();
            //reader.Dispose();

            //verify the tag
            foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
            {
                try
                {
                    string shippingDestinationType = e.SelectSingleNode("*[local-name() = 'shippingDestinationType']").InnerText;
                }
                catch (Exception)
                {
                    Console.WriteLine("Missing the shippingDestinationType tag. Failed!!!");
                    msgSubject = "Errors in resolution XML file: shippingDestinationType tag";
                    msgBody = "\n Missing the shippingDestinationType tag. Failed!!!\n File Name: " + fileName;
                    try
                    {
                        //es.SendEmailMethod(msgSubject, msgBody);

                        if (File.Exists(fileName))
                        {
                            MoveErrorFiles(fileName);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            //verify the content
            while (reader.Read())
            {
                string clientDamageCdCon;
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:shippingDestinationType")
                {
                    clientDamageCdCon = reader.ReadString();
                    if (clientDamageCdCon == "")
                    {
                        Console.WriteLine("The shippingDestinationType is empty. Failed!!!\n");
                        msgSubject = "Errors in resolution XML file: shippingDestinationType content";
                        msgBody = "\n The content of shippingDestinationType tag is empty. Failed!!!\n File Name: " + fileName;
                        try
                        {
                            //es.SendEmailMethod(msgSubject, msgBody);

                            if (File.Exists(fileName))
                            {
                                MoveErrorFiles(fileName);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }

                }
            }

            reader.Close();
            //reader.Dispose();
        }

        //integrated methods for moving error files
        private static void MoveErrorFiles(string fileName)
        {
            //this region part is for moving the error files method
            #region
            ResolutionFileLocation rf = new ResolutionFileLocation();
            MoveFailedFile mv = new MoveFailedFile(fileName, fileName.Remove(0, rf.outboundPath.Length));
            mv.Move();
            #endregion
        }
    }
}
