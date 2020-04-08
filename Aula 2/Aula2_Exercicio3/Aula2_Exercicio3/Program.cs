using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, area_quad, result, p_i;

            Console.Write("Digite um valor para o raio: ");
            area = double.Parse(Console.ReadLine());
            p_i = 3.1415926535;

            area_quad = Math.Pow(area, 2);

            result = p_i * area_quad;

            Console.Write("O valor da área do circulo é; " + result);
            Console.ReadKey();


        }
    }
}
