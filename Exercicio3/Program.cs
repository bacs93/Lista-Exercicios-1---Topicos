using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o custo de fábrica: ");
            decimal custo_fabrica = decimal.Parse(Console.ReadLine());

            decimal perc_distribuideor = 0.28m;

            decimal perc_impostos = 0.45m;

            decimal distribuidor = custo_fabrica * perc_distribuideor;

            decimal impostos = custo_fabrica * perc_impostos;

            decimal custo_final = custo_fabrica + distribuidor + impostos;

            Console.Write("\nPorcentagem do distribuidor: " + distribuidor);

            Console.Write("\nValor dos Impostos: " + impostos);

            Console.Write("\nCusto final: " + (custo_fabrica + distribuidor + impostos));


            Console.ReadKey();
        }
    }
}
