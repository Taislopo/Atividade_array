using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Crie um programa que armazene 20 números e separe-os em dois arrays: um com números pares" +
            // " e outro com números ímpares."

            int[] impares = {1,3,5,7,11,13,15,17,21,23,25,27,31,33,35,37,41,43,45 };
            int[] pares = {2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36,38,40,42,44,46 };

            for (int i = 0; i < impares.Length; i++) 
            {
                Console.WriteLine($" numeros impares do array foi {impares[i]}: ");
                Console.WriteLine($" numeros pares do array foi {pares[i]}: ");
            }
















        }
    }
}
