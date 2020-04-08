using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, ab, ac, al, qtlitros, qtlatas, custo;
            const double p1 = 3.14;

            Console.Write("Informe a Altura do tanque em metros: ");
            h = double.Parse(Console.ReadLine());

            Console.Write("Informe o raio do tanque em metros: ");
            r = double.Parse(Console.ReadLine());

            al = (2 * p1 * r * h);
            ab = p1 * Math.Pow(r, 2);
            ac = ab + al;
            qtlitros = (ac / 3) * 2;
            qtlatas = qtlitros / 5;
            custo = qtlatas * 40.00;

            Console.WriteLine("Qtde de Latas para pintar o tanque {0:N} ", qtlatas);
            Console.WriteLine("Custo para pintar o tanque {0:N}", custo);

            Console.ReadKey();
        }
    }
}
