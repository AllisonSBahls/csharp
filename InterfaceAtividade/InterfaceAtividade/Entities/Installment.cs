using System;
using System.Globalization;

namespace InterfaceAtividade.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {
        }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate 
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
