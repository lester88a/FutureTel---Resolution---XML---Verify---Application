using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

            //verify the repairResolutionList
            reader.MoveToContent();
            while (reader.Read())
            {
                
                //find the specific tag (ervmt:repairResolutionCode) of the resolution XML file
                string repairResolutionCode = null;
                //if (reader.NodeType == XmlNodeType.Element && reader.Name == "tns:repairOrderResolution>")
                //{
                //    //while (reader.Read())
                //    //{
                //        if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionList")
                //        {
                //            //while (reader.Read())
                //            //{
                //                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
                //                {
                //                    if (repairResolutionCode == "")
                //                    {
                //                        Console.WriteLine(" has empty repairResolutionCode!!!");
                //                    }
                //                    else
                //                    {
                //                        Console.WriteLine("OK");
                //                    }
                //                }
                //            //}
                //        }
                //    //}

                //}
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "tns:repairOrderResolution")
                {
                    Console.WriteLine("yes");
                    
                }
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
                {
                    repairResolutionCode = reader.ReadString();
                    if (repairResolutionCode == "")
                    {
                        Console.WriteLine("The repairResolutionCode is empty. Failed!!!\n");
                    }


                }
                //if (reader.NodeType == XmlNodeType.Element && reader.Name.Contains("ervmt:repairResolutionList"))
                //{
                //    Console.WriteLine("++++++++++++++++");
                //}

                //if (reader.NodeType == XmlNodeType.Element && reader.Name == "ervmt:repairResolutionCode")
                //{
                //    repairResolutionCode = reader.ReadString();
                //    if (repairResolutionCode == "")
                //    {
                //        //throw new Exception("The repairResolutionCode is empty!!\n");
                //        Console.WriteLine("The repairResolutionCode is empty. Failed!!!\n");
                //    }
                    
                //}
                
            }
        }
    }
}
