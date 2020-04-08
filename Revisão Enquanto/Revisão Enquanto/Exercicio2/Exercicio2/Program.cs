using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double massa;
            double tempo=0;

            Console.Write("informe a massa ");
            massa = double.Parse(Console.ReadLine());

            while(massa > 0.05)
            {
                massa = massa / 2;
                tempo = tempo + 50;
            }

            Console.WriteLine("valor massa " + massa);
            Console.Write("tempo gasto " + tempo);
            Console.ReadKey();          
        }
    }
}
