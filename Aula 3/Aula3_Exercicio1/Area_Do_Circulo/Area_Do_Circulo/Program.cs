using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {

           const double pi = 3.1415926535;

            double r, area;

            Console.WriteLine("Cálculo da área de uma circunferencia \n");
            Console.WriteLine("Fórmula => area = pi * raio^2 \n");

            Console.Write("Informe o valor do raio: ");
            r = double.Parse(Console.ReadLine());

            area = pi * Math.Pow(r, 2);

            Console.WriteLine("Área = {0}", area);
            Console.WriteLine("Área = {0:N}", area);
            Console.WriteLine("Área = {0:N5}", area);
            Console.ReadKey();
            
        }
    }
}
