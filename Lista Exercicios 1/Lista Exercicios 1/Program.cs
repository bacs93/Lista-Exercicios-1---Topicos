using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());

            int idade_total = ((2020-ano)*365) - (mes*30) - (dia);

            Console.Write("Idade em dias: " + idade_total);

            Console.ReadKey();
        }
    }
}
