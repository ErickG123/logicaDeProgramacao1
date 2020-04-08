using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num1 = new double[10];
            double[] num2 = new double[10];
            double[] soma = new double[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Informe o {0}º valor a ser armazenado em A => ", i + 1);
                num1[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Informe o {0}º valor a ser armazenado em B => ", i + 1);
                num2[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i <= 9; i++)
            {
                soma[i] = num1[i] + num2[i];
            }

            Console.Clear();

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("O resultado da soma das é => " + soma[i]);
            }

            Console.ReadKey();
        }
    }
}
