using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vanderleia", sobrenome = "Olivato", nome_completo;
            nome_completo = nome + " " + sobrenome;

            Console.WriteLine(nome + sobrenome);
            Console.WriteLine(nome_completo);

            Console.WriteLine(nome + " possui " + nome.Length + " letras");
            Console.WriteLine(sobrenome + " possui " + sobrenome.Length + " letras");
            Console.WriteLine(nome_completo + " possui " + nome_completo.Length + " letras");
            Console.WriteLine("Nome em Minusculo: " + nome.ToLower());
            Console.WriteLine("Nome em Maiusculo: " + nome.ToUpper());

            Console.WriteLine(nome + " é igual ao " + sobrenome + "?" + nome.Equals(nome));
            Console.WriteLine(nome.Equals("Vanderleia"));
            Console.WriteLine(nome.Substring(3, 7));

            Console.ReadKey();
        }
    }
}
