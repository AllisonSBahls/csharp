using System;
using System.IO;
using System.Collections.Generic;
namespace WorkingFile
{
    class WorkDirectory
    {
        public void WorkingDirectory()
        {
            string path = @"c:\temp\myfolder";
            try
            {
                //também pode var
                //IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //informar pastas
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);        
                }
                //procurar arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Criar pasta
                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
