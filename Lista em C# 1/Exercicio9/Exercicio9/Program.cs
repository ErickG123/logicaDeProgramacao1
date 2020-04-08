using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, cotacao, real;

            Console.Write("Digite a cotação do dolar: ");
            cotacao = double.Parse(Console.ReadLine());

            Console.Write("Digite quantos dolares você possui: ");
            dolar = double.Parse(Console.ReadLine());

            real = dolar * cotacao;

            Console.Write("Com uma quantia de" + dolar + "você possui: R$" + real);

            Console.ReadKey();
        }
    }
}
