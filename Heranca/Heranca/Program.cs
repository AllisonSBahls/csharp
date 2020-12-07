using System;
using Heranca.Entities;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            //Caso tence account.Balance = 100.00 acontecerá um erro por o balance esta como protect o que permite acesso apenas das subclasses


        }
    }
}
