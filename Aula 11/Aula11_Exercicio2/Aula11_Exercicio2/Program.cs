using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Aula11_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            while(cont < 1000)
            {            
                Console.WriteLine(cont);
                cont = cont + 1;

                Thread.Sleep(500);
            }
            
            Console.ReadKey();
        }
    }
}
