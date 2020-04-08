using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double cf, comissao, impostos, custo_final;

            Console.Write("Informe o custo de fabrica do veículo: ");
            cf = double.Parse(Console.ReadLine());

            comissao = cf * (25.0 / 100.0);
            impostos = cf * (45.0 / 100.0);

            custo_final = cf + comissao + impostos;

            Console.WriteLine("Valor da Comissão do vendedor: {0:N}", comissao);
            Console.WriteLine("Valor dos impostos: {0:N}", impostos);
            Console.WriteLine("Custo final do veículo: {0:N}", custo_final);

            Console.ReadKey();
        }
    }
}
