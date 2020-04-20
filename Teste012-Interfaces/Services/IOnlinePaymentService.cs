using System;
using System.Collections.Generic;
using System.Text;

namespace Teste012_Interfaces
{
    interface IOnlinePaymentService
    {
        public double Interest(double amount, int months);
    }
}
