using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int speso = 0, bmen, bmai;

            for(int i = 0; i <= 4; i++)
            {
                Console.Write("Informe o peso do {0}º boi => ");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 4; i++)
            {
                speso = speso + num[i];
            }
        }
    }
}
