using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sal = new double[5];
            double[] salFinal = new double[5];
            string[] nome = new string[5];
            double[] reajuste = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe o nome do funcionário => ");
                nome[i] = Console.ReadLine();
            }

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe o salário do funcionário => ");
                sal[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Informe o reajuste do funcionário => ");
                reajuste[i] = double.Parse(Console.ReadLine());  
            }

            for (int i = 0; i <= 4; i++)
            {
                salFinal[i] = sal[i] + (sal[i] * (reajuste[i] / 100));
            }

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Nome funcionário => " + nome[i]);
                Console.WriteLine("Salário funcionário => " + salFinal[i]);
            }

            Console.ReadKey();
        }
    }
}
