using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            double taxa;         
            double prestacao;
            double valor;

            //Pedindo o valor da prestação sem o juros para o usuario
            Console.Write("Digite a taxa da prestação: ");
            valor = double.Parse(Console.ReadLine());

            //Pedindo o tempo de atraso 
            Console.Write("Digite quantos dias de atraso: ");
            tempo = int.Parse(Console.ReadLine());

            //Pedindo o valor da taxa de juros
            Console.Write("Digite o valor da taxa de juros: ");
            taxa = double.Parse(Console.ReadLine());

            prestacao = (valor * (taxa / 100) * tempo);

            //Mostrando quanto ele vai ter que pagar com a taxa
            Console.Write("O valor que você tera que pagar com a taxa é de: R$" + prestacao);

            Console.ReadKey();
        }
    }
}
