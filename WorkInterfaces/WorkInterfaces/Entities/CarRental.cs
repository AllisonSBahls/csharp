using System;
using System.Collections.Generic;
using System.Text;

namespace WorkInterfaces.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public Vehicles Vehicles { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicles vehicles)
        {
            Start = start;
            Finish = finish;
            Vehicles = vehicles;
            //Invoice sera nullo e devera ser iniciado depois
            Invoice = null; // Opcional colocar
        }
    }
}
