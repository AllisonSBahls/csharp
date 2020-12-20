using System;
using InterfaceAtividade.Entities;

namespace InterfaceAtividade.Services
{
    class PayPalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
                return  amount * 0.01 * months;

        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
