using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            double altura, peso;
            double hma = 0, hmm = 999999, mmb = 999999 , mmg = 0;
            int cont = 1;

            while(cont <= 4)
            {
                Console.Write("Informe o sexo da {0}ª pessoa => ", cont);
                sexo = Console.ReadLine();

                Console.Write("Informe a altura da {0}ª pessoa => ", cont);
                altura = double.Parse(Console.ReadLine());

                Console.Write("Informe o peso da {0}ª pessoa => ", cont);
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("*************************************");

                if(sexo.ToUpper() == "M")
                {
                    if(altura > hma)
                    {
                        hma = altura;
                    }

                    if(peso < hmm)
                    {
                        hmm = peso;
                    }
                }
                else
                {
                    if(altura < mmb)
                    {
                        mmb = altura;
                    }
                    if(peso > mmg)
                    {
                        mmg = peso;
                    }
                }

                cont++;
            }
            Console.WriteLine("O homem com maior altura tem {0:N} mts.", hma);
            Console.WriteLine("O homem com menor pesso tem {0:N} kgs.", hmm);
            Console.WriteLine("O mulher com menor altura tem {0:N} mts.", mmb);
            Console.WriteLine("O mulher com maior pesso tem {0:N} kgs.", mmg);

            Console.ReadKey();
        }
    }
}
