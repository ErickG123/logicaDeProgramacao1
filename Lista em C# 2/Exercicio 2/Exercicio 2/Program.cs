using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetorA = new double[6];
            double[] vetorB = new double[6];
            double[] vetorC = new double[6];
            int j = 0;

            for(int i = 0; i <= 5; i++)
            {
                Console.Write("Informe os valores a serem armazenados => ");
                vetorA[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 5; i >= 0; i--)
            {
                vetorB[j] = vetorA[i];
                j++;
            }
         
            for (int i = 0; i <=5; i++)
            {
                j--;
                vetorC[j] = vetorB[i];               
            }

            Console.Clear();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("O vetor A na ordem inversa => {0}", vetorB[i]);
                Console.WriteLine("O vetor B na ordem inversa => {0}", vetorC[i]);
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
