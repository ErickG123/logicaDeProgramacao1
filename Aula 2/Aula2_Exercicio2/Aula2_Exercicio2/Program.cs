using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, result;

            Console.Write("Digite o número: ");
            num1 = double.Parse(Console.ReadLine());

            result = Math.Pow (num1, 2);

            Console.WriteLine("O valor da potencia é: "+ result);
            Console.ReadKey(); 

        }
    }
}
