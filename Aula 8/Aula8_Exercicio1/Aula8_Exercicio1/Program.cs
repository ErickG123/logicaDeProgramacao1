using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.WriteLine("======CALCULANDO A MÉDIA======");
            Console.Write("Informe a sua primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a sua segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a sua terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.Clear();

            if (media >= 7)
            {
                Console.WriteLine("Com a média => " + media);
                Console.Write("Você foi aprovado");
            }
            else
            {
                Console.WriteLine("Com a média => " + media);
                Console.Write("Você foi reprovado");
            }

            Console.ReadKey();
        }
    }
}
