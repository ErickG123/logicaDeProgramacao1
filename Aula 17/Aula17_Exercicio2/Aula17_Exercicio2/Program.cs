using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num1 = new double[10];
            double[] num2 = new double[10];

            for(int i = 0;i <= 9; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                num1[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i <= 9; i++)
            {
                num2[i] = num1[i];
                Console.WriteLine(num2[i]);
            }

            Console.ReadKey();
        }
    }
}
