using System;
using System.Globalization;

namespace ExercicioAbstract.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double calc = 0.0;
            if(AnualIncome < 20000.00)
            {
                calc = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                calc = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }

            return calc;
        }

        public override string ToString()
        {
            return Name + ": $" + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
