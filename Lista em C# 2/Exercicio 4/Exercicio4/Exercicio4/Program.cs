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
            int[] ano = new int[5];
            int somaidade = 0, idade;
            double media;

            for(int i = 0; i <= 4; i++)
            {
                Console.Write("Iforme o {0}º ano de nascimento => ", i + 1);
                ano[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i <= 4; i++)
            {
                idade = 2019 - ano[i];
                somaidade = somaidade + idade;
                Console.WriteLine("Idade de {0}ª pessoa => {1}", i + 1, idade);
            }

            media = somaidade / 5.0;
            Console.WriteLine("Médias das idade => {0:N1}", media);

            Console.ReadKey();
        }
    }
}
