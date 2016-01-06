using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileScan
{
    class ResolutionFileLocation
    {
        //current app location
        public string currentLocation = System.AppDomain.CurrentDomain.BaseDirectory;
        //public outboundPath
        public string outboundPath = System.AppDomain.CurrentDomain.BaseDirectory + @"outbound";
        

        public ResolutionFileLocation()
        {
            Console.WriteLine("Your current working directory is: {0}", currentLocation);
            
            EnsureOutboundPath();
        }

        public void EnsureOutboundPath()
        {
            try
            {
                if (!Directory.Exists(outboundPath))
                {
                    Console.WriteLine("The outboundPath did not exists, Creating a outboundPath folder...");
                    Directory.CreateDirectory(outboundPath);
                    Console.WriteLine("The outboundPath is created.");
                    Console.WriteLine("Your outboundPath is: {0}", outboundPath); 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The run.vbs File did not find");
            }
            

        } 
    }
}
