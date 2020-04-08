using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo, corolhos, corcabelo;
            double idade = 0, maiorIdade = 0, qtedIndFemId = 0, qtedIndVerLouros = 0;

            Console.Write("Informe sua idade => ");
            idade = int.Parse(Console.ReadLine());

            while(idade != -1)
            {
                Console.Write("Informe seu sexo => ");
                sexo = Console.ReadLine();

                Console.Write("Informe a cor do seu cabelo => ");
                corcabelo = Console.ReadLine();

                Console.Write("Informe a cor dos seus olhos => ");
                corolhos = Console.ReadLine();
              
                if(idade > maiorIdade)
                {
                    maiorIdade = idade;
                }

                if((sexo == "Feminino") && ((18 <= idade) && (idade <= 35)))
                {
                    qtedIndFemId = qtedIndFemId + 1;
                }

                if((corolhos == "Verde") && (corcabelo == "Loiro"))
                {
                    qtedIndVerLouros = qtedIndVerLouros + 1;
                }

                Console.Write("Informe sua idade => ");
                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Maior idade entre os habitante => " + maiorIdade);
            Console.WriteLine("Quantidade de mulher entre 18 e 35 anos => " + qtedIndFemId);
            Console.Write("Quantidades de pessoas com olhos verdes e cabelos louros => " + qtedIndVerLouros);

            Console.ReadKey();
        }
    }
}
