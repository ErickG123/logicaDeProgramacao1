using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheits, celsius;

            Console.Write("Informe a temperatura em Graus Fahrenheits: ");
            fahrenheits = double.Parse(Console.ReadLine());

            celsius = (fahrenheits - 32) * 5 / 9;

            Console.Write("O valor da conversão de "+ fahrenheits + " graus fahrenheits para graus celsius é de: "+ celsius + " graus celsius");

            Console.ReadKey();
        }
    }
}
