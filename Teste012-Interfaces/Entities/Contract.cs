using System;
using System.Collections.Generic;
using System.Text;

namespace Teste012_Interfaces
{
    class Contract //Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public string ListInstallments()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Installment i in Installments)
            {
                sb.AppendLine(i.DueDate.ToString("dd/MM/yyyy") + " - " + i.Amount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
            }

            return sb.ToString();

        }

    }
}
