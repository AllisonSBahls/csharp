using System;
using System.Globalization;

namespace ExercicioAbstract.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double imp = 0.0;
            if(NumberOfEmployees > 10)
            {
                imp += AnualIncome * 0.14;
            }
            else
            {
                imp += AnualIncome * 0.16;
            }
            return imp;
        }
        public override string ToString()
        {
            return Name + ": $" + Tax().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
