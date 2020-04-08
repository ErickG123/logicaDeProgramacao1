using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double qpares =0, qimpares =0;
            int cont = 0;
            
            while (cont <= 14)
            {
                Console.Write("informe os numeros ");
                num = double.Parse(Console.ReadLine());

                if (num %2 == 0)
                {
                    qpares++;
                }

                else
                {
                    qimpares++;
                }

                cont++;
            }

            Console.WriteLine("qpares " + qpares);
            Console.WriteLine("qimpares "+qimpares);
            Console.ReadKey();
        }
    }
}
