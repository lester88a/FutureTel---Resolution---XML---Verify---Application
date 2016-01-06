using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

                
                //call the VerifyResolutionFile class
                VerifyResolutionFile vfFile = new VerifyResolutionFile();
                vfFile.VerifyResolutionFileMethod(); //call the method

                //ResolutionFileLocation rl = new ResolutionFileLocation();
                //Console.WriteLine("The outboundPath is: {0}",rl.outboundPath);

                //GenerateLog ge = new GenerateLog();
                //ge.GenLog();
                Console.WriteLine("Press any key to exit....");
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("Errors:\n" + e);
            }
           
            

        }
    }
}
