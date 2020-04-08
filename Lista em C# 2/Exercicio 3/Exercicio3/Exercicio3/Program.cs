using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[5];
            int qtde7 = 0 , qtde50 = 0;


            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe o {0}º número => ", i+1);
                num[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 4; i++)
            {
                if (num[i] > 50)
                {
                    qtde50++;
                }

                if (num[i] < 7)
                {
                    qtde7++;
                }
            }

            Console.WriteLine("Números maiores que 50 => " + qtde50);
            Console.WriteLine("Números menores que 7 => " + qtde7);

            Console.ReadKey();
        }
    }
}
