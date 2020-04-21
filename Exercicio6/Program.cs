using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salário fixo: ");
            double s_fixo = double.Parse(Console.ReadLine());

            Console.Write("Vendas: ");
            double vendas = double.Parse(Console.ReadLine());

            double s_total = 0;

            if (vendas <= 1500)
            {
                s_total = (s_fixo + vendas * 0.03);
            }
            else
            {
                s_total = (s_fixo + 1500 * 0.03) + ((vendas - 1500) * 0.05);
            }

            Console.Write("\nSalário total: " + s_total);

            Console.ReadKey();
        }
    }
}
