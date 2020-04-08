using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist, temp, vel, lit;

            Console.Write("Quanto tempo você gastou na viajem ? ");
            temp = double.Parse(Console.ReadLine());

            Console.Write("Qual foi sua velocidade durante a viajem ? ");
            vel = double.Parse(Console.ReadLine());

            dist = (temp * vel);

            lit = (dist / 12);

            Console.WriteLine("Sua velocidade foi de " + vel +" km/h");
            Console.WriteLine("Você percorreu uma distancia de " + dist + " km");
            Console.WriteLine("Você demorou " + temp + " horas" );
            Console.Write("Você gastou " + lit + " litros na viajem");

            Console.ReadKey();
        }
    }
}
