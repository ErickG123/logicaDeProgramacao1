using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Exercici1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;

            Console.WriteLine("Digite uma frase: ");
            palavra = Console.ReadLine();
        
            Console.WriteLine("A quantidade de letras da frase é: " + palavra.Length);
            Console.WriteLine("A frase começando do decimo caracter é: " + palavra.Substring(10, palavra.Length - 10));

            Console.ReadKey();


        }
    }
}
