using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    //Para que a BusinessAccount herde os atributos e metodos da conta basta colocar a Account depois de dois pontos
    class BusinessAccount : Account
    {
        public double LoanLimite { get; set; }
        public BusinessAccount() { }

        //Como o construtor da subclasse não pega os dados automaticamente da superclasses deve ser colocado manualmente.
        //Também pode ser feito um reaproveitamos do construtor da superclasse trazendo ele para o construto da subclasse,
        //fazendo o reuso do codigo e diminuindo a quantidade digitada.
        public BusinessAccount(int number, string holder, double balance, double loanLimite) : base(number, holder, balance)
        {
            LoanLimite = loanLimite;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimite)
            {
                Balance += amount;
            }
        }
    }
}
