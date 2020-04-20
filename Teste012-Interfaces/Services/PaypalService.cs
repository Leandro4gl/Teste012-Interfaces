using System;
using System.Collections.Generic;
using System.Text;

namespace Teste012_Interfaces
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int monthParcela)
        {
            double jurosSimples = amount * (1.00 + (monthParcela / 100.00));
            double paymentFee = jurosSimples * 1.02;
            
            return paymentFee;
        }
        
    }
}
