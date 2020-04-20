using System;

namespace Teste012_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numContrato = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double valContrato = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int np = int.Parse(Console.ReadLine());

            Contract c = new Contract(numContrato, dataContrato, valContrato);

            ContractService contrServ = new ContractService(new PaypalService());
            contrServ.ProcessContract(c, np);

            Console.WriteLine("Installments:");
            Console.WriteLine(c.ListInstallments());


        }
    }
}
