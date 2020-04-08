using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Write("Informe o primeiro => ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo => ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro => ");
            n3 = int.Parse(Console.ReadLine());

            if((n1 < n2 ) && (n1 < n3))
            {
                Console.WriteLine("N1 é o numero => " + n1);       
            }
            else if ((n2 < n1) && (n2 < n3))
            {
                Console.WriteLine("N2 é o menor número => " + n2);
            
            }
            else
            {
                Console.WriteLine("N3 é o menor número => " + n3);
            }
            Console.ReadKey();
        }
    }
}
