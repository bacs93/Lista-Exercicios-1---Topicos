using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();

            for (int i=0; i<3; i++)
            {
                Console.Write("Informe o " + (i + 1) + "º valor: ");
                int v = int.Parse(Console.ReadLine());
                valores.Add(v);
            }

            int maior = valores.Max();

            Console.Write("\nO maior valor é: " + maior);

            Console.ReadKey();
        }
    }
}
