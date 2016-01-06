using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLFileScan
{
    class MoveFailedFile
    {
        //local variables
        string sourceFile; //source file location
        string errorFilesPath = System.AppDomain.CurrentDomain.BaseDirectory + @"errorXMLFiles";//destination
        string fileName;
        //constructor
        public MoveFailedFile(string sourceFile, string fileName)
        {
            this.sourceFile = sourceFile;
            this.errorFilesPath += fileName;
            this.fileName = fileName;
        }

        public void Move()
        {
            try
            {
                //ensure that the target dir is exist
                if (!Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory + @"errorXMLFiles"))
                {
                    Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory + @"errorXMLFiles");
                }
                //ensure that the target does not exist
                if (File.Exists(errorFilesPath))
                {
                    //if the error file in the error folder already exist, then copy to a new file name[_1.xml], and delete the old file
                    File.Copy(errorFilesPath,System.AppDomain.CurrentDomain.BaseDirectory + @"errorXMLFiles\"+fileName.Replace(".xml","_1.xml"));
                    File.Delete(errorFilesPath);
                }
                //move the file
                if (File.Exists(sourceFile))
                {
                    File.Move(sourceFile, errorFilesPath);
                }
            }
            catch (Exception)
            { 
                throw;
            }
           
            
        }
    }
}
