using System;
using System.IO;


namespace WorkingFile
{
    class Writer
    {
        public void WriterStream()
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                //AppendText abre o arquivo como permissão de escrita
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred" );
                Console.WriteLine(e.Message);
            }
        }
    }
}
