using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, total;

            Console.Write("Informe o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            total = (n1 + n2) * n3;

            Console.WriteLine("O valor da Operação é " + total);

            Console.ReadKey();
        }
    }
}
