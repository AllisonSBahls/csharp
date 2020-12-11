using System;
using System.IO;

namespace WorkingFile
{
    class FileStreamAndStreamReader
    {
        public void FileStream()
        {
            //Caminho do arquivo
            string path = @"c:\temp\file1.txt";

            //instanciando FileStream e inicializando ela
            StreamReader sr = null;

            //FileStream fs = null;

            try
            {
                /*Recurso externo ele não é gerenciado pelo .net ou seja deve ser fechado
                Instancia o arquivo com a finalidade de acesso*/

                //fs = new FileStream(path, FileMode.Open);
                /*A partir do sr pode fazer a leiutra do arquivo*/

                /*O OPEN TEXT implicitamente faz instanciação do FileStream e StreamReader*/
                sr = File.OpenText(path);
                //Ler mais de uma linha
                while (!sr.EndOfStream) //Enquanto não for o final do arquivo
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                //string line = sr.ReadLine();
                //Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            //fechar os arquivos independente se deu certo ou não
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
