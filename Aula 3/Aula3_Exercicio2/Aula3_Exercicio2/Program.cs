using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, m;

            Console.WriteLine("===========================");
            Console.WriteLine("CALCULANDO A MÉDIA ESCOLAR ");
            Console.WriteLine("===========================");
            Console.WriteLine("AULA DO BIDU ");
            Console.WriteLine("===========================");

            Console.Write("Informe a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            m = (n1 + n2 + n3) / 3;

            Console.WriteLine("===========================");
            Console.WriteLine("Sua média é: {0:N2} ", m);
            Console.WriteLine("===========================");
            Console.ReadKey();

        }
    }
}
