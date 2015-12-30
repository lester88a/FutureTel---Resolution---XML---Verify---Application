using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XMLFileScan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ////parameter for file location
                ////string fileLocation = from line in File.ReadAllLines("run.vbs")
                ////                      let pm = line.Split("=")
                ////                      select new KeyValuePair<string,string>(pm[0],pm[1]);

                //call the VerifyResolutionFile class
                VerifyResolutionFile vfFile = new VerifyResolutionFile();
                vfFile.VerifyResolutionFileMethod(); //call the method

                //XmlDocument doc = new XmlDocument();
                //doc.Load(@"D:\XML\Sample3.xml");

                //XmlNamespaceManager nameSpaceManager = new XmlNamespaceManager(doc.NameTable);

                //nameSpaceManager.AddNamespace()

                //XNamespace tns = "http://xmlschema.tmi.telus.com/srv/RMO/ResourceMgmt/EquipmentRepairVendorManagementSvcRequestResponse_v1";
                //XNamespace ervmt = "http://xmlschema.tmi.telus.com/xsd/Resource/Resource/EquipmentRepairVendorManagement_v1";
                //doc.CreateElement(tns.NamespaceName, "repairOrderResolution");
                //doc.CreateElement(ervmt.NamespaceName + "repairID");
                //doc.CreateElement(ervmt.NamespaceName + "repairResolutionList");
                
                //doc.CreateElement("tns", "repairOrderResolution", tns.NamespaceName);
                //doc.CreateElement("ervmt", "repairID", ervmt.NamespaceName);
                //doc.CreateElement("tns", "repairResolutionList", ervmt.NamespaceName);

                ////doc.Load(@"D:\XML\Sample1.xml".Substring(@"D:\XML\Sample1.xml".IndexOf(Environment.NewLine)));
                ////doc.LoadXml(@"D:\XML\Sample1.xml".Substring(@"D:\XML\Sample1.xml".IndexOf(Environment.NewLine)));
                //XPathDocument docNav = new XPathDocument(new StringReader(@"D:\XML\Sample1.xml"));
                //XPathNavigator navigator = docNav.CreateNavigator();
                //XPathNodeIterator NodeIter = navigator.Select("/bigBook/books/book");
                //foreach (XPathNavigator selectedNode in NodeIter)
                //{
                //    var a = "<root>" + selectedNode.InnerXml + "</root>";
                //    var x = XDocument.Parse(a);
                //    Console.WriteLine(x.Root.Element("bookName").Value);
                //    if (x.Root.Element("bookID") != null)
                //    {
                //        Console.WriteLine(x.Root.Element("bookID").Value);
                //    }
                //    else
                //    {
                //        Console.WriteLine("NOOOOOOO");
                //    }
                //}

                //foreach (XmlElement e in doc.SelectNodes("//tns:repairOrderResolution")) 
                //{
                //    string bookID = e.SelectSingleNode("ervmt:repairID").InnerText;
                //    //string bookName = e.SelectSingleNode("ervmt:repairResolutionList").InnerText;
                //    Console.WriteLine(bookID);
                //    //Console.WriteLine("{0}: {1}", bookID, bookName);
                //}

                //foreach (XmlElement e in doc.SelectNodes("//*[local-name() = 'repairOrderResolution']"))
                //{
                //    string bookID = e.SelectSingleNode("*[local-name() = 'repairID']").InnerText;
                //    string bookName = e.SelectSingleNode("*[local-name() = 'repairResolutionList']").InnerText;

                //    Console.WriteLine("{0}: {1}\n\n", bookID, bookName);
                //}
   
            }
            catch (Exception e)
            {

                Console.WriteLine("Errors:\n" + e);
            }
           
            

        }
    }
}
