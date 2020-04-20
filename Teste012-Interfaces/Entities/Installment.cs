using System;
using System.Collections.Generic;
using System.Text;

namespace Teste012_Interfaces
{
    class Installment // Prestação
    {
        public DateTime DueDate { get; set; } //Data Vencimento
        public double Amount { get; set; } //Montante

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
