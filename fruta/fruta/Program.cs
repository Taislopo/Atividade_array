using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Implemente um sistema que armazene as quantidades de 5
            //  //tipos de frutas em 3 cestas e calcule o total de frutas de cada tipo."

            string[] tiposFrutas = { "Maçã", "Banana", "Laranja", "Uva", "Pera" };

            int[,] cestas = new int[3, 5];

            cestas[0, 0] = 5;
            cestas[0, 1] = 3;
            cestas[0, 2] = 2;
            cestas[0, 3] = 4;
            cestas[0, 4] = 1;

            cestas[1, 0] = 2;
            cestas[1, 1] = 4;
            cestas[1, 2] = 3;
            cestas[1, 3] = 1;
            cestas[1, 4] = 5;

            cestas[2, 0] = 3;
            cestas[2, 1] = 1;
            cestas[2, 2] = 5;
            cestas[2, 3] = 2;
            cestas[2, 4] = 4;

            int[] totais = new int[5];

            for (int fruta = 0; fruta < 5; fruta++)
            {
                for (int cesta = 0; cesta < 3; cesta++)
                {
                    totais[fruta] += cestas[cesta, fruta];
                }
            }

            Console.WriteLine("Total de frutas por tipo:");
            Console.WriteLine("Maçã: " + totais[0]);
            Console.WriteLine("Banana: " + totais[1]);
            Console.WriteLine("Laranja: " + totais[2]);
            Console.WriteLine("Uva: " + totais[3]);
            Console.WriteLine("Pera: " + totais[4]);

            Console.WriteLine("\nConteúdo das cestas:");
            for (int cesta = 0; cesta < 3; cesta++)
            {
                Console.Write("Cesta " + (cesta + 1) + ": ");
                Console.Write(cestas[cesta, 0] + " Maçã ");
                Console.Write(cestas[cesta, 1] + " Banana ");
                Console.Write(cestas[cesta, 2] + " Laranja ");
                Console.Write(cestas[cesta, 3] + " Uva ");
                Console.Write(cestas[cesta, 4] + " Pera ");
                Console.WriteLine();
            }
        }
    }
}
