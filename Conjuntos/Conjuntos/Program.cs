using System;
using System.IO;
using Conjuntos.Entities;
using System.Collections.Generic;
namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> set = new HashSet<LogRecords>();

            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecords { Username = name, Instant = instant });

                    }
                Console.WriteLine("Total Users: " + set.Count);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
