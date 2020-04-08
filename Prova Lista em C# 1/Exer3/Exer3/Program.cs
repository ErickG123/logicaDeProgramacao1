using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, d;

            Console.Write("Qual o valor de x1 ? ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor de x2 ? ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor de y1 ? ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor de y2 ? ");
            y2 = double.Parse(Console.ReadLine());

            d = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));

            Console.Write("A distância entre os dois pontos é de => {0:N}", d);

            Console.ReadKey();
        }
    }
}
