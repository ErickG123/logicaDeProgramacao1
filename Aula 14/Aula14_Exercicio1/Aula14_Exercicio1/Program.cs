using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, qtdecand1 = 0, qtdecand2 = 0, qtdecand3 = 0, qtdebrancos = 0, qtdenulos = 0, voto ;
            double percand1 = 0, percand2 = 0, percand3 = 0, perbrancos = 0, pernulos = 0;

            //10 é a quantidade de vezes que vai se repetir
            while(cont <= 10)
            {
                //Pede o voto ate a condição ser verdadeira
                Console.Write("Informe seu voto: ");
                voto = int.Parse(Console.ReadLine());

                //Limpa a tela para não mostrar o voto anterior
                Console.Clear();

                //Vendo em quem a pessoa votou
                //Adicionando o voto a variável 
                if (voto == 11)
                {
                    qtdecand1++;
                }
                else if(voto == 22)
                {
                    qtdecand2++;
                }
                else if(voto == 33)
                {
                    qtdecand3++;
                }
                else if(voto == 0)
                {
                    qtdebrancos++;
                }
                else
                {
                    qtdenulos++;
                }

                cont++;
            }

            //Calculando os percentuais
            percand1 = (qtdecand1 * 100) / 10;
            percand2 = (qtdecand2 * 100) / 10;
            percand3 = (qtdecand3 * 100) / 10;
            perbrancos = (qtdebrancos * 100) / 10;
            pernulos = (qtdenulos * 100) / 10;

            //Mostrando os valores
            Console.WriteLine("     Eleições ETEC 2024");
            Console.WriteLine("*******************************");
            Console.WriteLine("      Resultado final");
            Console.WriteLine("*******************************");
            Console.WriteLine("Candidato 1 => {0} voto(s) - {1:N}%", qtdecand1, percand1);
            Console.WriteLine("Candidato 2 => {0} voto(s) - {1:N}%", qtdecand2, percand2);
            Console.WriteLine("Candidato 3 => {0} voto(s) - {1:N}%", qtdecand3, percand3);
            Console.WriteLine("Votos brancos => {0} voto(s) - {1:N}%", qtdebrancos, perbrancos);
            Console.WriteLine("Votos nulos => {0} voto(s) - {1:N}%", qtdenulos, pernulos);

            Console.ReadKey();
        }
    }
}
