using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, fat = 1, cont = 1;

            Console.Write("Informe o fatorial => ");
            num = double.Parse(Console.ReadLine());

            while(num >= cont)
            {
                fat = fat * cont;

                cont++;
            }

            Console.Write("Seu fatorial é => " + fat);
            Console.ReadKey();
        }
    }
}
