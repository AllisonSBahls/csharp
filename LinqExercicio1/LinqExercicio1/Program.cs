using System;
using System.IO ;
using System.Linq ;
using System.Globalization;
using System.Collections.Generic;
using LinqExercicio1.Entities;
namespace LinqExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            
            Console.Write("Enter with salary: ");
            double salaryValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine("Email of people whose salary is more than: " + salaryValue);
            var emails = list.Where(p => p.Salary > salaryValue).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();
            var sumSalary = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumSalary);
            /*List<Product> list = new List<Product>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }
            //transforma a lista de produto em double de preços
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }
            */

        }
    }
}
