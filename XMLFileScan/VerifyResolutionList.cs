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
        //XmlReader aReader;

        //constructor
        public VerifyResolutionList()
        {
            //this.aReader = reader;
        }

        //method
        public void VerifyResolutionListMethod(string fileName)
        {
            XmlReader reader = XmlReader.Create(fileName);

            //elements
            string repairOrderResolution = null;
            string repairResolutionList = null;
            string repairResolutionCode = null;

            //declare a repairIDCount variable
            int repairOrderResolutionCount = 0;
            int repairResolutionListCount = 0;

            //verify the repairResolutionList
            reader.MoveToContent();
            while (reader.Read())
            {

                //find the specific tag (ervmt:repairResolutionCode) of the resolution XML file

                //if (reader.NodeType == XmlNodeType.Element && reader.Name == "tns:repairOrderResolution")
                //{
                //    while (reader.Read())
                //    {
                //        if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionList")
                //        {
                //            while (reader.Read())
                //            {
                //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
                //                {
                //                    repairResolutionCode = reader.ReadString();
                //                    if (repairResolutionCode == "")
                //                    {
                //                        Console.WriteLine(" has empty repairResolutionCode. Failed!!!");
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}



                //if (reader.NodeType == XmlNodeType.Element && reader.Name == "tns:repairOrderResolution" )
                //{
                //    repairOrderResolutionCount++;
                //    Console.WriteLine("repairOrderResolution: {0}", repairOrderResolutionCount);

                //    //while (reader.Read())
                //    //{
                //    //    if (reader.NodeType == XmlNodeType.Element && reader.Name.Contains("ervmt:repairResolutionList"))
                //    //    {
                //    //        if (reader.IsEmptyElement)
                //    //        {
                //    //            Console.WriteLine("NOOOOO");
                //    //        }
                //    //    }
                //    //}

                //}
                //if (reader.NodeType == XmlNodeType.Element && reader.Name.Contains("ervmt:repairResolutionList"))
                //{
                //    repairResolutionListCount++;
                //    Console.WriteLine("repairResolutionList: ------- {0} -------", repairResolutionListCount);
                    
                    
                //}
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
                {
                    repairResolutionCode = reader.ReadString();
                    if (repairResolutionCode == "")
                    {
                        Console.WriteLine("The repairResolutionCode is empty. Failed!!!\n");
                    }

                }
                
                
                
            }
            //Console.WriteLine("Total repairOrderResolutionCount: {0}, Total repairResolutionListCount: {1}", repairOrderResolutionCount, repairResolutionListCount);


            //This is verify the missling whole part of the repairResolutionList tag
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
            {
                try
                {
                    string bookID = e.SelectSingleNode("*[local-name() = 'repairID']").InnerText;
                    string bookName = e.SelectSingleNode("*[local-name() = 'repairResolutionList']").InnerText;
                    
                }
                catch (Exception)
                {

                    Console.WriteLine("Missing the whole part of the repairResolutionList tag. Failed!!!"); ;
                }
                

                //Console.WriteLine("{0}: {1}\n\n", bookID, bookName);
            }
        }
    }
}
