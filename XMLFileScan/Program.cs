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

                //call the VerifyResolutionFile class
                VerifyResolutionFile vfFile = new VerifyResolutionFile();
                vfFile.VerifyResolutionFileMethod(); //call the method

            }
            catch (Exception e)
            {

                Console.WriteLine("Errors:\n" + e);
            }
           
            

        }
    }
}
