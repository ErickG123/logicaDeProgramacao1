using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, m;
            string nome;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe a primeira nota: ");
            n1=double.Parse(Console.ReadLine());

            Console.Write("Informe a sugunda nota: ");
            n2=double.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            n3=double.Parse(Console.ReadLine());

            m = (n1 + n2 + n3) / 3;

            Console.Write("O aluno " + nome + "terminou com a média:{0:N2}", m);

            Console.ReadKey();

        }
    }
}
