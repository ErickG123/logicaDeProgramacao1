using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 500;
            double total, entrada;           

            Console.Write("Digite o valor do seu cheque: ");
            entrada = double.Parse(Console.ReadLine());

            total = saldo + entrada;

            Console.Write("Sua conta possui " + total);

            Console.ReadKey();

        }
    }
}
