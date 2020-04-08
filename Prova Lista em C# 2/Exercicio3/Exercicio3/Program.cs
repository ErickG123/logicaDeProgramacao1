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
            double idade, salario, salarioTotal = 0, medSalario, maiorIdade = 0, menorIdade = 0, qtdeMulher = 0, qtdeHomem = 0;
            string sexo;
            int cont = 0;

            while (cont < 5)
            {
                Console.Write("Informe sua idade => ");
                idade = double.Parse(Console.ReadLine());

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }

                else
                {
                    menorIdade = idade;
                }

                Console.Write("Informe seu sexo => ");
                sexo = Console.ReadLine();

                if (sexo == "M")
                {
                    qtdeHomem = qtdeHomem++;
                }

                else
                {
                    qtdeMulher = qtdeMulher++;
                }

                Console.Write("Informe seu salário => ");
                salario = double.Parse(Console.ReadLine());

                salarioTotal = salarioTotal + salario;

                cont++;
            }

            medSalario = salarioTotal / cont;

            Console.WriteLine("Médio de salário => {N:0}" + medSalario);
            Console.WriteLine("Maior idade => " + maiorIdade);
            Console.WriteLine("Menor idade => " + menorIdade);
            Console.WriteLine("Qtde homens => " + qtdeHomem);
            Console.WriteLine("Qtde mulheres => " + qtdeMulher);

            Console.ReadKey();
        }
    }
}
