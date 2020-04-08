using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;

            Console.Write("O animal é mamífero ? ");
            resultado = Console.ReadLine();

            if (resultado == "Sim")
            {
                Console.Write("Seu animal é quadrupede ? ");
                resultado = Console.ReadLine();
                if (resultado == "Sim")
                {
                    Console.Write("Seu animal é carnívoro ? ");
                    resultado = Console.ReadLine();
                    if (resultado == "Sim")
                    {
                        Console.Write("Seu animal é um leão");
                    }
                    else if(resultado == "Não")
                    {
                        Console.Write("Seu animal é um cavalo");
                    }
                }

            

                if (resultado == "Não")
                {
                    Console.Write("Seu animal é bípede ? ");
                    resultado = Console.ReadLine();
                    if (resultado == "Sim")
                    {
                        Console.Write("Seu animal é onívoro ? ");
                        resultado = Console.ReadLine();
                        if (resultado == "Sim")
                        {
                            Console.Write("Seu animal é o homem");
                        }
                        else if (resultado == "Não")
                        {
                            Console.Write("Seu animal é um macaco");
                        }
                    }

                }

                if (resultado == "Não")
                {
                    Console.Write("Seu animal é voador ? ");
                    resultado = Console.ReadLine();
                    if (resultado == "Sim")
                    {
                        Console.Write("Seu animal é um morcego");
                    }
                    else
                    {
                        Console.Write("Seu animal é uma baleia");
                    }
                }
            }

            Console.ReadKey();
        } 
    }
}
