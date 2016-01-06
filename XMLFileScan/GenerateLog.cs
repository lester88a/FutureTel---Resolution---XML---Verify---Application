using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileScan
{
    class GenerateLog
    {
        //call ResolutionFileLocation
        ResolutionFileLocation rl = new ResolutionFileLocation();

        FileStream ostrm;
        StreamWriter writer;
        TextWriter oldOut = Console.Out;

        public void GenLog()
        {
            try
            {
                ostrm = new FileStream(@"C:\Users\lester\Google Drive\FutureTel\Dec 2015\errorXMLFiles\Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);

            }
            catch (Exception e)
            {
                Console.WriteLine("Connot open redirect.txt for writing");
                Console.WriteLine(e.Message);
            }

            Console.SetOut(writer);
            Console.WriteLine("This is a line of text");
            Console.WriteLine("Everyting written to ");
            Console.WriteLine("to a file");
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }
    }
}
