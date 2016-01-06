using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XMLFileScan
{
    class VerifyResolutionList
    {
        //call the EmailService
        EmailService es = new EmailService();

        //private instance variables
        private string msgSubject = "";
        private string msgBody = "";
         

        //constructor
        public VerifyResolutionList()
        {

        }

        //verify repairResolutionList field
        public void VerifyrepairResolutionList(string fileName)
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
                    string ascWarrantyCd = e.SelectSingleNode("*[local-name() = 'repairResolutionList']").InnerText;
                }
                catch (Exception)
                {
                    Console.WriteLine("Missing the repairResolutionList tag. Failed!!!");
                    msgSubject = "Errors in resolution XML file: repairResolutionList tag";
                    msgBody = "\n Missing the repairResolutionList tag. Failed!!!\n File Name: " + fileName;
                    try
                    {
                        //es.SendEmailMethod(msgSubject, msgBody);

                        //this region part is for moving the error files method
                        #region
                        ResolutionFileLocation rf = new ResolutionFileLocation();
                        MoveFailedFile mv = new MoveFailedFile(fileName, fileName.Remove(0, rf.outboundPath.Length));
                        mv.Move();
                        #endregion
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
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
                {
                    clientDamageCdCon = reader.ReadString();
                    if (clientDamageCdCon == "")
                    {
                        Console.WriteLine("The content of repairResolutionCode tag is empty. Failed!!!\n");
                        msgSubject = "Errors in resolution XML file: repairResolutionCode content";
                        msgBody = "\n The content of repairResolutionCode tag is empty. Failed!!!\n File Name: " + fileName;
                        try
                        {
                            //es.SendEmailMethod(msgSubject, msgBody);

                            //this region part is for moving the error files method
                            #region
                            ResolutionFileLocation rf = new ResolutionFileLocation();
                            MoveFailedFile mv = new MoveFailedFile(fileName, fileName.Remove(0, rf.outboundPath.Length));
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

            reader.Close();
            //reader.Dispose();

        }

        //method
        //public void VerifyResolutionListMethod(string fileName)
        //{
        //    XmlReader reader = XmlReader.Create(fileName);

        //    //elements
        //    string repairOrderResolution = null;
        //    string repairResolutionList = null;
        //    string repairResolutionCode = null;

        //    //declare a repairIDCount variable
        //    int repairOrderResolutionCount = 0;
        //    int repairResolutionListCount = 0;

        //    //verify the repairResolutionList
        //    reader.MoveToContent();
        //    while (reader.Read())
        //    {

        //        //find the specific tag (ervmt:repairResolutionCode) of the resolution XML file

        //        //if (reader.NodeType == XmlNodeType.Element && reader.Name == "tns:repairOrderResolution")
        //        //{
        //        //    while (reader.Read())
        //        //    {
        //        //        if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionList")
        //        //        {
        //        //            while (reader.Read())
        //        //            {
        //        //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
        //        //                {
        //        //                    repairResolutionCode = reader.ReadString();
        //        //                    if (repairResolutionCode == "")
        //        //                    {
        //        //                        Console.WriteLine(" has empty repairResolutionCode. Failed!!!");
        //        //                    }
        //        //                }
        //        //            }
        //        //        }
        //        //    }
        //        //}



        //        //if (reader.NodeType == XmlNodeType.Element && reader.Name == "tns:repairOrderResolution" )
        //        //{
        //        //    repairOrderResolutionCount++;
        //        //    Console.WriteLine("repairOrderResolution: {0}", repairOrderResolutionCount);

        //        //    //while (reader.Read())
        //        //    //{
        //        //    //    if (reader.NodeType == XmlNodeType.Element && reader.Name.Contains("ervmt:repairResolutionList"))
        //        //    //    {
        //        //    //        if (reader.IsEmptyElement)
        //        //    //        {
        //        //    //            Console.WriteLine("NOOOOO");
        //        //    //        }
        //        //    //    }
        //        //    //}

        //        //}
        //        //if (reader.NodeType == XmlNodeType.Element && reader.Name.Contains("ervmt:repairResolutionList"))
        //        //{
        //        //    repairResolutionListCount++;
        //        //    Console.WriteLine("repairResolutionList: ------- {0} -------", repairResolutionListCount);
                    
                    
        //        //}

        //        //this verify the repairResolutionCode part
        //        if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
        //        {
        //            repairResolutionCode = reader.ReadString();
        //            if (repairResolutionCode == "")
        //            {
        //                Console.WriteLine("The repairResolutionCode is empty. Failed!!!\n");
                        
        //                email = vf.email;
        //                msgSubject = vf.msgSubject;
        //                msgBody += vf.msgBody + "\n The repairResolutionCode is empty. Failed!!!\n File Name: " + fileName;
        //                try
        //                {
        //                    //es.SendEmailMethod(email, msgSubject, msgBody);
        //                }
        //                catch (Exception)
        //                {
                            
        //                    throw;
        //                }
                        
        //            }
                    
        //        }
                
                
                
        //    }
        //    //display the number of repairResolutionListCount
        //    //Console.WriteLine("Total repairOrderResolutionCount: {0}, Total repairResolutionListCount: {1}", repairOrderResolutionCount, repairResolutionListCount);


        //    //This verify the missling whole part of the repairResolutionList tag
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load(fileName);

        //    foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
        //    {
        //        try
        //        {
        //            string repairID = e.SelectSingleNode("*[local-name() = 'repairID']").InnerText;
        //            string repairResolutionLists = e.SelectSingleNode("*[local-name() = 'repairResolutionList']").InnerText;
        //        }
        //        catch (Exception)
        //        { 
        //            Console.WriteLine("Missing the whole part of the repairResolutionList tag. Failed!!!");
        //            email = vf.email;
        //            msgSubject = vf.msgSubject;
        //            msgBody += vf.msgBody + "\n Missing the whole part of the repairResolutionList tag. Failed!!!\n File Name: "+ fileName;
        //            try
        //            {
        //                //es.SendEmailMethod(email, msgSubject, msgBody);
        //            }
        //            catch (Exception)
        //            {
                        
        //                throw;
        //            } 
        //        } 
        //    }

        //}
    }
}
