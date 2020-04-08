using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            Console.Write("Informe o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("O resultado da soma é: ");
            resultado = n1 + n2;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
