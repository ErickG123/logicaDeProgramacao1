using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalgraos = 1, somagraos = 0;


            for (int i = 1; i <= 64; i++)
            {
                if (i > 1)
                {
                    totalgraos = totalgraos * 2;
                }
                Console.WriteLine("Dia {0} => {1:N0} grão(s)", i, totalgraos);
                somagraos = somagraos + totalgraos;
                
            }
            Console.WriteLine("Total ganho pelo monge => {0:N0} grão(s)", somagraos);
            Console.ReadKey();
        }
    }
}
