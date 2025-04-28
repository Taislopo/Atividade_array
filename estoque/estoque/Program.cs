using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Implemente um sistema que armazene a quantidade de 50 produtos em estoque e informe
            // o produto com maior e menor quantidade disponível

            double[] quantidade = new double[50];
            double max = quantidade.Max(), min = quantidade.Min();
            int posimaior = 0, posimenor=0;

            for (int i = 0; i<=50; i ++)
            {
                Console.WriteLine($"Digite a quantidade do {i+1} produto: "  );
                quantidade[i] = double.Parse( Console.ReadLine() );
                if (quantidade[i]>max)
                {
                    max = quantidade[i];
                    posimaior = i;
                }
                else if (quantidade[i] < min)
                {
                    min = quantidade[i];
                    posimenor = i;
                }
            }
            Console.WriteLine($"O produto que teve a maior quantidade foi o produto {posimaior} com {max} de quantidade!! ");
            Console.WriteLine($"O produto que teve a menor quantidade foi o produto {posimenor} com {min} de quantidade!! ");




        }
    }
}
