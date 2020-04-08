using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.Write("Informe o ano atual => ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 1)
            {
                Console.Write("O ano não é bissexto");
            }
            else
            {
                Console.Write("O ano é bissexto");
            }
            Console.ReadKey();
        }
    }
}
