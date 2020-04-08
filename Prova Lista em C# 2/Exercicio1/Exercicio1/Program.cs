using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salFixo, salFinal, qtdeCar, com, valVenda, com2;

            Console.Write("Informe o valor do salário mínimo => ");
            salFixo = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de carros vendidos => ");
            qtdeCar = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de suas vendas => ");
            valVenda = double.Parse(Console.ReadLine());

            com = 50.00 * qtdeCar;
            com2 = valVenda * 0.05;

            salFinal = salFixo + com + com2;

            Console.Write("Seu salário final é de => " + salFinal + " reais");

            Console.ReadKey();
        }         
    }
}
