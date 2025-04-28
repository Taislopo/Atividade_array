using System;

namespace historico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //"Desenvolva um programa que armazene o histórico de compras de 100 clientes " +
            //"e mostre o total gasto por cada cliente."

            string[] clintes = new string[100];
            double[] gasto = new double[100];

            for (int i = 0; i <100;i++)
            {
                Console.WriteLine($" Digite o nome do {i+1} cliente: ");
                clintes[i] = Console.ReadLine();
                Console.WriteLine(" Digite seu gasto nesse site: ");
                gasto[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($" O gasto do cliente {clintes[i]} foi de {gasto[i]} reais ");
            }










        }
    }
}
