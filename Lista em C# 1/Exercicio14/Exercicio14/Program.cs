using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite oi valor de A => ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B => ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Valor Trocado de A =>" + a);
            Console.WriteLine("Valor Trocado de B =>" + b);

            Console.ReadKey();
        }
    }
}
