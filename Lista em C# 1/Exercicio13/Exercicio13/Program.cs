using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double na, nb, nc, delta, val1, val2;

            Console.WriteLine("Informe o valor de A ");
            na = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B ");
            nb = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor de C ");
            nc = double.Parse(Console.ReadLine());

            delta = (nb * nb) - (4 * na * nc);

            val1 = (-nb + Math.Sqrt(delta))/(2*na);
            val2 = (-nb - Math.Sqrt(delta))/(2*na);

            Console.WriteLine("Os Possíveis Resultados São : " + val1 + " ou " + val2);

            Console.ReadKey();
        }
    }
}
