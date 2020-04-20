using System;
using System.Collections.Generic;
using System.Text;

namespace Teste012_Interfaces
{
    class ContractService
    {
        private IOnlinePaymentService _PaymentService;
        public ContractService(IOnlinePaymentService PaymentService)
        {
            _PaymentService = PaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double valorParcela = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime dataParcela = contract.Date.AddMonths(i);
                double valorComImpostos = _PaymentService.Interest(valorParcela, i);

                contract.Installments.Add(new Installment(dataParcela, valorComImpostos));
            }
        }
    }
}
