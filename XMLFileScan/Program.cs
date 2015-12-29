using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                ////local variable for targetDirectory
                //string targetDirectory = "D:\\XML";
                //string[] fileNames = Directory.GetFiles(targetDirectory, "*.xml");
                ////string fileNameWithoutPath = Path.GetFileName(fileNames);
                //for (int i = 0; i < fileNames.Length; i++)
                //{
                //    //Console.WriteLine(fileNames[i]);
                //    if (fileNames[i].Contains("RESOLUTION"))
                //    {
                //        Console.WriteLine();
                //        Console.WriteLine("Found: " + fileNames[i]);

                //        //ReadXML rxml = new ReadXML(fileNames[i]);
                //        //ReadXML rxmls = new ReadXML("D:\\XML\\Sample1.xml");

                //    }
                   
                //}

                ReadXMl2 rxml2 = new ReadXMl2();
            }
            catch (Exception e)
            {

                Console.WriteLine("Errors:\n" + e);
            }
           
            

        }
    }
}
