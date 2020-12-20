using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dessa forma sera na instanciação que sera definido o tipo dela
            PrintService<int> printService = new PrintService<int>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
