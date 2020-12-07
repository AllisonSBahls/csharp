/*Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo
(próxima página).*/
using System;
using Composicao.Entities.Enums;
using Composicao.Entities;
using System.Globalization;
//Dica: Não é preciso manter o namespace no mesmo caminho das pastas
//Mas ajuda  a identificar a localização delas;
namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departamen's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Ente worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando o departamento com o nome do departamento e  armazenando na variavel dep
            Departament dept = new Departament(deptName);

            // Passando as informações para os parametros do construdor de Worker
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contract to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:" );
                
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Duration (hour): ");
                int hour = int.Parse(Console.ReadLine());
                
                HourContract contract = new HourContract(date, valuePerHour, hour);

                //Adicionar o contrato ao trabalhador
                //Sera executado de acordo com numero de for
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            //Para pegar o mes e o ano separadamente sera utilizado o subString que permite o recorte da string
            //Dessa forma a variavel monthAndYear sera recortado 2 casa a partir da posição 0, ou seja as posições 0 e 1 que corresponde ao MM;
            int month = int.Parse(monthAndYear.Substring(0, 2));

            //Da mesma pode ser feita para pegar o ano, que no caso so sera definido a parti da posição 3 até o final da string ano
            int year = int.Parse(monthAndYear.Substring(3));

            //Pegando as informações
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine($"Income for {monthAndYear}: " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture);
        }   
    }
}
