    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int prestacoes, pago;
            double valorPres, valorPago;
            double total;

            Console.Write("Digite a quantidade de pretações: ");
            prestacoes = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de cada pretação: ");
            valorPres = double.Parse(Console.ReadLine());

            Console.Write("Quantas pretações você pagou? ");
            pago = int.Parse(Console.ReadLine());

            total = (prestacoes * valorPres) - (pago * valorPres);
            valorPago = pago * valorPres;

            Console.WriteLine("Você já pagou: R$" + valorPago);
            Console.Write("O total que ainda falta pagar é de: R$" + total);

            Console.ReadKey();
        }
    }
}
