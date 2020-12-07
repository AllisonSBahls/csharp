using System;
using Heranca.Entities;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            //Console.WriteLine(account.Balance);

            //Caso tence account.Balance = 100.00 acontecerá um erro por o balance esta como protect o que permite acesso apenas das subclasses

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //Upcasting
            //Conversão da subclasse para uma superclasse
            //A varia account recebe naturalmente um objeto de qualquer tipo de subclasse dela e isso é chamado de UPCASTING
            Account acc1 = bacc; //Compilador aceita numa boa =) vpois a Conta de negocios é uma conta
            Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //Downcasting - Insegura / Usar quando realmente necessário
            //Conversão da superclasse para uma subclasse
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            //Instanciando o ACC3 que esta como savings account se der um downcasting como business acount apesar do compilador aceitar, irár ocorrer  um erro no tempo de execução
            //BusinessAccount acc5 = (BusinessAccount) acc3;
            
            //Testando se o acc3 é de businessAccount - irá ocorrer um erro pois o acc3 é de SavingsAccount
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            //Esse irá rodar normalmente
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                //Outra forma de casting é
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");

            }
        }

    }
}
