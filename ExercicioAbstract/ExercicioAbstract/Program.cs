using System;
using ExercicioAbstract.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



                if (ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmployees));
                }

            }
            Console.WriteLine();
            double total = 0.0;

            foreach (TaxPayer item in list)
            {
                total += item.Tax();
            }

            foreach (TaxPayer obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $" + total);
            
        }
    }
}
