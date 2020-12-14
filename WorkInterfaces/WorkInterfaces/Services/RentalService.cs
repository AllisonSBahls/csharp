using System;
using WorkInterfaces.Entities;

namespace WorkInterfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get;  private set; }
        public double PricePerDay { get; private set; }

        //Jeito inadequado
        //private BrasilTaxService _brasilTaxService = new BrasilTaxService();
        
        //Usando interface
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            //pegando a duração da locação
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
