using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2, n3;
            double comissao, venda1, venda2, venda3, totalVenda;

            Console.Write("Informe o nome do primeiro corretor  => ");
            n1 = Console.ReadLine();

            Console.Write("Informe o nome do segundo corretor => ");
            n2 = Console.ReadLine();

            Console.Write("Informe o nome do terceiro corretor => ");
            n3 = Console.ReadLine();

            Console.Clear();

            Console.Write("Informe o total de vendas do primeiro corretor => ");
            venda1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do segundo corretor => ");
            venda2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do terceiro corretor => ");
            venda3 = double.Parse(Console.ReadLine());

            Console.Clear();

            if(venda1 > 50000)
            {
                comissao = venda1 * 0.12;
                Console.WriteLine("O funcionário " + n1);
                Console.WriteLine("Vendeu => {0:N}", venda1);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);
            }
            else if((venda1 >= 30000) && (venda1 <= 50000))
            {
                comissao = venda1 * 0.095;
                Console.WriteLine("O funcionário " + n1);
                Console.WriteLine("Vendeu => {0:N}", venda1);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);
            }
            else
            {
                comissao = venda1 * 0.07;
                Console.WriteLine("O funcionário " + n1);
                Console.WriteLine("Vendeu => {0:N}", venda1);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);

            }

            if (venda2 > 50000)
            {
                comissao = venda2 * 0.12;
                Console.WriteLine("O funcionário " + n2);
                Console.WriteLine("Vendeu => {0:N}", venda2);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);
            }
            else if ((venda2 >= 30000) && (venda2 <= 50000))
            {
                comissao = venda2 * 0.095;
                Console.WriteLine("O funcionário " + n2);
                Console.WriteLine("Vendeu => {0:N}", venda2);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);
            }
            else
            {
                comissao = venda2 * 0.07;
                Console.WriteLine("O funcionário " + n2);
                Console.WriteLine("Vendeu => {0:N}", venda2);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);

            }

            if (venda3 > 50000)
            {
                comissao = venda3 * 0.12;
                Console.WriteLine("O funcionário " + n3);
                Console.WriteLine("Vendeu => {0:N}", venda3);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);
            }
            else if ((venda3 >= 30000) && (venda3 <= 50000))
            {
                comissao = venda3 * 0.095;
                Console.WriteLine("O funcionário " + n3);
                Console.WriteLine("Vendeu => {0:N}", venda3);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);
            }
            else
            {
                comissao = venda3 * 0.07;
                Console.WriteLine("O funcionário " + n3);
                Console.WriteLine("Vendeu => {0:N}", venda3);
                Console.WriteLine("Sua comissão é de => {0:N}", comissao);

            }

            totalVenda = venda1 + venda2 + venda3;

            Console.Write("O lucro total da empresa é de => {0:N}", totalVenda);

            Console.ReadKey();
        }
    }
}
