using System;
using System.IO;


namespace WorkingFile
{
    class Program
    {
        /*Para instancia de FILE trabalhada como FileInfo, FileStream, Using entre outros
         * foram criados classes separadas e nelas metódos para realizarem os testes com
         * o objetivo de manter tudo em um mesmo projeto*/
        static void Main(string[] args)
        {
           
            /*FileAndFileInfo file = new FileAndFileInfo();
            file.FilesFirst();
            */
           
            /*FileStreamAndStreamReader fssr = new FileStreamAndStreamReader();
            fssr.FileStream();*/

            BlockUsing bu = new BlockUsing();
            bu.Using();

        }
    }
}
