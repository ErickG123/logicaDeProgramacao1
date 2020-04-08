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
            int[] j = new int[5];
            int num;

            for( int i = 0; i <= 4; i++)
            {
                Console.Write("Difige o {0}º valor do vetor => ", i + 1);
                j[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.Write("Informe um número => ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
            {
                if (num == j[i])
                {
                    Console.Write("O número {0} faz parte do vetor na posição {1} => ", num, i);
                }
            }

            Console.ReadKey();
        }
    }
}
