using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, curso;
            double n1, n2, n3, mp;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe seu curso: ");
            curso = Console.ReadLine();

            Console.Write("Informe a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segundo nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());

            mp = ((n1 * 2) + (n2 * 3) + (n3 * 3)) / 8;

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Você faz o curso: " + curso);
            Console.Write("Sua média ponderada é de: {0:N3} " , mp);

            Console.ReadKey();
        }
    }
}
