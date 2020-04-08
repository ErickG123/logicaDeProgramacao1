using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sp, si, cont;
            sp = 0;
            si = 0;
            cont = 1;

            while (cont <= 3)
            {
                Console.Write("Informe o número => ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    sp = sp + num;
                }
                else
                {
                    si = si + num;
                }
                cont = cont + 1;
            }

                Console.WriteLine("Soma números pares => " + sp);
                Console.Write("Soma números impares => " + si);

                Console.ReadKey();        
        }
    }
}
