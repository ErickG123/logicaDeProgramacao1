using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, vendas, salarioFinal;
            string vendedor;

            Console.Write("Informe o salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de suas vendas: ");
            vendas = double.Parse(Console.ReadLine());

            Console.Write("Informe o seu nome: ");
            vendedor = Console.ReadLine();

            salarioFinal =(vendas * 15 / 100)+ salario;

            Console.WriteLine("Vendedor: " + vendedor);
            Console.WriteLine("O vendedor tem uma salario fixo de: " + salario);
            Console.WriteLine("O salario do vendedor com comissão é de: " + salarioFinal);

            Console.ReadKey();
        }
    }
}
