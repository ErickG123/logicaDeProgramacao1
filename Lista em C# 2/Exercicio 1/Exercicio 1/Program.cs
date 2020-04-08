using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[15];
            double spar = 0;
            double simp = 0;
            double npar = 0;
            double nimp = 0;

            for (int i = 0; i <= 14; i++)
            {
                Console.Write("Informe os valores a serem armazenados no vetor => ");
                num[i] = double.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    spar = spar + num[i];
                }

                else
                {
                    simp = simp + num[i];
                }

                if (num[i] % 2 == 0)
                {
                    npar = npar + 1;
                }
                 
                else
                {
                    nimp = nimp + 1;
                }
            }

            Console.Clear();

            Console.WriteLine("Soma números com indicador par => " + spar);
            Console.WriteLine("Soma números com indicador impar => " + simp);
            Console.WriteLine("Quantidade de números pares => " + npar);
            Console.Write("Quantidade de números impares => " + nimp);

            Console.ReadKey();
        }
    }
}
