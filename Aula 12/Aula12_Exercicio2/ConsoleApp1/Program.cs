using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;

            Console.Write("Digite o número que deseja saber a tabuada => ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0 || numero > 10) 
            {
                Console.Write("Número inválido por favor digite um número de 0 a 10");
            }
            else
            {
                while (contador < 11)
                {
                    Console.WriteLine(numero + " x " + contador + " = " + numero * contador);
                    contador = contador + 1;
                }
            }
            Console.ReadKey();
        }
    }
}