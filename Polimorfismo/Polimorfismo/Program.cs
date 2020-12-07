using System;
using System.Collections.Generic;
using Polimorfismo.Entities;
using System.Globalization;
namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando uma lista do tipo Employee(Funcionario)
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)> ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
                if (ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Basicamente aqui já temos caso de polimorfismo, pois a lista do tipo Employee esta recebendo dados de uma  outra classe a qual é sua subclasse
                    list.Add(new OutersourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    //E aqui ele recebe dados da classe
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
