using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, elev;

            Console.Write("Informe o Valor do Primeiro Numero: ");
            n1 = int.Parse(Console.ReadLine());

            elev = n1 * n1;

            Console.Write(n1 + " elevado ao quadrado é igual a: " + elev);

            Console.ReadKey();
        }
    }
}
