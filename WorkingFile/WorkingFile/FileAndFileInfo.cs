using System;
using System.IO;

namespace WorkingFile
{
    class FileAndFileInfo
    {
        public void FilesFirst()
        {
            //Buscando o arquivo criado - é usado o @ para não precisar digitar \\
            string sourcePath = @"c:\temp\file1.txt";
            string targePath = @"c:\temp\file2.txt";
            try
            {
                //Instancia o objeto que estará associado ao arquivo que existir no caminhoq ue for passado que no caso é o sourcePath
                FileInfo fileInfo = new FileInfo(sourcePath);

                //Ler todas as linhas do arquivo e guardar em um vetor passando nele o arquivo
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

                //Copiando para o arquivo instanciado para o local destino
                fileInfo.CopyTo(targePath);
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }
    }
}
