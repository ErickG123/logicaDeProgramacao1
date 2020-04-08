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
            double sal, des;

            Console.Write("Informe o seu salário => ");
            sal = double.Parse(Console.ReadLine());

            des = sal * 0.11;

            if (des < 318.20)
            {
                Console.Write("Seu desconto é de => " + des + " reais");
            }

            else
            {
                Console.Write("Seu desconto é de R$318,20" );
            }

            Console.ReadKey();
        }
    }
}
