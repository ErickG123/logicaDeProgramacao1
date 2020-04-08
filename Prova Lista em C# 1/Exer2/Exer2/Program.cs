using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, pdesc, sdesc;

            Console.Write("Qual o seu salário atual ? ");
            sal = double.Parse(Console.ReadLine());

            pdesc = (sal - (sal * (9.5 / 100.0)));

            sdesc = (pdesc - (pdesc * (4.5 / 100.0)));

            Console.WriteLine("Seu salário com o desconto da previdência social é de => {0:N}", pdesc);
            Console.WriteLine("Seu salário com o desconto do imposto é de => {0:N}", sdesc);
            Console.Write("Portanto seu salário final é de => {0:N}", sdesc);

            Console.ReadKey();
        }
    }
}
