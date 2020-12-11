using System;
using System.IO;

namespace WorkingFile
{
    class BlockUsing
    {
        public void Using()
        {
            string path = @"c:\temp\file1.txt";
            try
            {
                //Tudo que estiver nesse bloco sera executado e instantaneamente fechado
                /*using (FileStream fs = new FileStream(path, FileMode.Open))*/
                //{
                //Pode ter varios blocos using
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}
            }
            catch (IOException e)
            {
                Console.WriteLine("An error Ocurred: " + e.Message);
            }
        }
    }
}
