using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
           double totalgrao = 1, somagraos = 0;

            for (int i = 1; i <= 64; i++)
            {
                if (i > 1)
                {
                    totalgrao = totalgrao * 2;
                }
                Console.WriteLine("{0}º dia => {1:N0}", i, totalgrao);
                somagraos = somagraos + totalgrao;
            }
            Console.WriteLine("Total recebido pelo monge => {0:N0}", somagraos);
            Console.ReadKey();
        }
    }
}
