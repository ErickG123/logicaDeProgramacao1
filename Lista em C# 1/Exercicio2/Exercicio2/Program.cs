using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, sub, mult, div, n1, n2;

            Console.Write("Informe o Valor do Primeiro Numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o Valor do Segundo Numero: ");
            n2 = double.Parse(Console.ReadLine());

            soma = n1 + n2;
            sub = n1 - n2;
            mult = n1 * n2;
            //div = (double) n1 / n2
            div = n1 / n2;

            Console.WriteLine("O valor da soma entre " + n1 + "e" + n2 + "é de: " + soma);
            Console.WriteLine("O valor da subtração entre " + n1 + "e" + n2 + "é de: " + sub);
            Console.WriteLine("O valor da multiplicação entre " + n1 + "e" + n2 + "é de: " + mult);
            Console.WriteLine("O valor da divisão entre " + n1 + "e" + n2 + "é de: " + div);

            Console.ReadKey();
        }
    }
}
