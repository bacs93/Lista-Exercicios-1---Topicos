using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total de votos nulos: ");
            int nulos = int.Parse(Console.ReadLine());


            Console.Write("Total de votos brancos: ");
            int brancos = int.Parse(Console.ReadLine());

            Console.Write("Total de votos válidos: ");
            int validos = int.Parse(Console.ReadLine());

            int total = nulos + brancos + validos;

            Console.Write("\nTotal de votos: " + total);

            Console.Write("\nVotos nulos: " + (nulos*100/total) +"%");

            Console.Write("\nVotos brancos: " + (brancos * 100 / total) + "%");

            Console.Write("\nVotos validos: " + (validos * 100 / total) + "%");


            Console.ReadKey();
        }
    }
}
