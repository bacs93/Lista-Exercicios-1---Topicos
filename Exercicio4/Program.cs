using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Salário fixo mensal: ");
            decimal s_fixo = decimal.Parse(Console.ReadLine());

            Console.Write("Valor da comissão fixa: ");
            decimal c_fixa = decimal.Parse(Console.ReadLine());

            Console.Write("Quantidade de carros vendidos: ");
            int carros_vedidos = int.Parse(Console.ReadLine());

            Console.Write("Valor total das vendas: ");
            decimal total_vendas = decimal.Parse(Console.ReadLine());

            decimal perc_comissao = 0.05m;

            decimal salario = total_vendas * perc_comissao;

            Console.Write("\nSalário final: " + (salario + s_fixo + carros_vedidos * c_fixa));

            Console.ReadKey();
        }
    }
}
