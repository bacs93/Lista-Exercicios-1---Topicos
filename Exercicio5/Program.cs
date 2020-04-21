using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.Write("\nInforme o sexo (M ou F): ");
            string sexo = Console.ReadLine();

            Console.Write("\nInforme a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double peso_ideal = 0;

            if (sexo == "M")
            {
                peso_ideal = (72.7 * altura) - 58;
            }
            else
            {
                peso_ideal = (62.1 * altura) - 44.7;
            }

            Console.Write("\nPeso ideal: " + peso_ideal);

            Console.ReadKey();




        }
    }
}
