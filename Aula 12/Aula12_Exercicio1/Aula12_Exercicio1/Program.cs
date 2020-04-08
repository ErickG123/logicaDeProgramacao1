using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double idC = 1.5, idZ = 1.1, ano = 0;
            
            while(idZ < idC)
            {
               
                idC = idC + 2;

                if(idZ > idC)
                {
                    ano = ano + 1;
                    idZ = idZ + 3;
                    ano = ano + 1;

                    Console.WriteLine("Zé é maior que Chico");
                    Console.WriteLine("Altura de Zé " + idZ);
                    Console.WriteLine("Altura de Chico " + idC);
                    Console.Write("Idade => " + ano);
                }                 
            }

            Console.ReadKey();
        }
    }
}
