using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    //Herdando as propriedades e metodos da classe employee
    class OutersourcedEmployee : Employee
    {
        //Acrescentar o que ele tem a mais que a super classe
        public double AdditionalCharge { get; set; }

        public OutersourcedEmployee()
        {

        }

        //Reaproveitando os construtores da super classe
        public OutersourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.10 * AdditionalCharge;
        }
    }
}
