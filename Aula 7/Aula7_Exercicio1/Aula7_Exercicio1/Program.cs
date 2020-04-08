using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Informe números difentes");
            Console.Write("Informe um número inteiro e positivo => ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Informe outro número inteiro e positivo => ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                Console.Write("O número " + n1 + " é maior que " + n2);
            }
            else
            {
                Console.Write("O número " + n1 + " não é maior que " + n2);
            }

            Console.ReadKey();
        }
    }
}
