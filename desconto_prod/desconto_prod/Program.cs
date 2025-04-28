using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desconto_prod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um sistema que armazene os preços de 10 produtos
            //e aplique um desconto de 10% em todos os preços.


            double[] preco = new double[10];

            for (int i = 0; i < preco.Length; i++)
            {
                Console.WriteLine($"Digite o valor do produto {i + 1}: ");
                preco[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPreços com 10% de desconto:");
           
            for (int i = 0; i < preco.Length; i++)
            {
                double comDesconto = precos[i] * 0.9;
                Console.WriteLine($"Produto {i + 1}: R$ {comDesconto:0.00}");
            }











        }
    }
}
