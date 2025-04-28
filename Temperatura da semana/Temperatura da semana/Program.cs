using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_da_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Crie um algoritmo que armazene as temperaturas diárias de uma cidade durante uma semana
           // e informe o dia mais quente e o mais frio.

            string[] dias = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };
            int[] temperatura = new int[dias.Length];
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine($"Digite quantos graus fez {dias[i]}");
                temperatura[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine($"Fez {temperatura[i]} graus em {dias[i]} ");
            }




        }
    }
}
