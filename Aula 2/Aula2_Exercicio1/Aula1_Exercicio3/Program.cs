using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, result;

            Console.Write("Informe o primeiro número: ") ;
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("O resultado é: ");
            result = n1 + n3 * n2;


            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}
