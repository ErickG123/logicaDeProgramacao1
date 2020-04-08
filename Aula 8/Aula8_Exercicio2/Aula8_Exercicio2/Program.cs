using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.Write("Informe um número => ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.Write("O número " + n1 + " é par");
            }
            else
            {
                Console.Write("O número " + n1 + " é impar");
            }
            Console.ReadKey();
        }
    }
}
