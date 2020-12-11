using System;
using System.IO;
namespace WorkingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileAndFileInfo file = new FileAndFileInfo();
            file.FilesFirst();
            */
            FileStreamAndStreamReader fssr = new FileStreamAndStreamReader();
            fssr.FileStream();
        }
    }
}
