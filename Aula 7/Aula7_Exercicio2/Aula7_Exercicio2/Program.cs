using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.Write("Informe a primeira nota => ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota => ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota => ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if(media >= 7)
            {
                Console.Write("Você foi aprovado na disciplina");
            }
            else
            {
                Console.Write("Você reprovou na disciplina");
            }
            Console.ReadKey();
        }
    }
}
