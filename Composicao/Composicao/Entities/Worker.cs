using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }
        /*
        COMPOSIÇÃO funciona da seguinte forma:
        Existe uma associação de Funcionario e Departamento
        Associação entre duas classes diferentes é feita do seguinte modo:
        */
        public Departament Departament { get; set; }

        //COMPOSIÇÃO de funcionario e contratos é uma lista por ser vários contratos que o usuário pode ter
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Garantido que ela não seja nula

        public Worker()
        {

        }

        /*Em construtores não é usual passar uma lista no construtor da classe, pois ela inicia de forma vazia
        Por conta disso ela não é inicializada no construtor*/
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        //Adicionar contratos
        public void AddContract(HourContract contracts) // Deve ser acesssar a lista de contratos e adicionar ele como parametro de entrada
        {
            Contracts.Add(contracts); //Adicionando um contrato usando a função do list
        }

        //Remover Contratos
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //Receber o ano e o mes para informar quando o funcionariu recebeu naquele tempo
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            //Percorrer minha lista de contratos
            foreach (HourContract contract in Contracts)
            {
                //Verificar que o valor do parametro bate com o ano do contrato para ele entrar na soma
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    // é feito a soma deles + o total das horas trabalhadas que esta em HourContract
                    //A formula de TotalValue é Hours*ValuePerHours
                    sum += contract.TotalValue();
                }
            }

            return sum;
            {

            }
        }
    }

    
}
