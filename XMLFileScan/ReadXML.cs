using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFileScan
{
    public class ReadXML
    {
       
        XmlTextReader reader;

        public ReadXML(string fileLocations)
        {
            reader = new XmlTextReader(fileLocations);
            while (reader.Read())
            {

                switch (reader.NodeType)
                {
                    case XmlNodeType.Element & XmlNodeType.Text:
                        if (reader.Name.Contains("ervmt:messageType"))
                        {
                            Console.Write("<" + reader.Name + ">");
                            Console.WriteLine(reader.Value.Length);
                        }
                        //Console.Write("<" + reader.Name + ">");
                        break;

                    case XmlNodeType.Text:
                        if (reader.Name.Contains("ervmt:messageType"))
                        {
                            Console.Write(reader.Value + reader.AttributeCount);
                        }
                        break;

                    case XmlNodeType.EndElement:
                        if (reader.Name.Contains("ervmt:messageType"))
                        {
                            Console.Write("</" + reader.Name + ">");
                        }
                       // Console.Write("</" + reader.Name + ">");
                        //Console.WriteLine();
                        break;

                    default:
                        break;
                }

                
            }
            
        }

       
    }
}
