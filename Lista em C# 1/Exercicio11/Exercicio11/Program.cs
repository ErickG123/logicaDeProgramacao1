using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, r, s;

            Console.Write("Digite um número inteiro e positivo para A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro e positivo para B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite um número inteiro e positivo para C: ");
            c = int.Parse(Console.ReadLine());

            r = (a + b) * (a + b);
            s = (b + c) * (b + c);
            d = (r + s) / 2;

            Console.Write("O valor da operação d = (r + s) /2 é: " +d);

            Console.ReadKey();
        }
    }
}
