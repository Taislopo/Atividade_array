using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amarzena_salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Implemente um sistema que armazene os salários de 50 funcionários e " 
            // "calcule a média salarial da empresa."

            double media = 0, soma=0;

            double[] salario = new double[50];
            for (int i = 0; i<=5; i++)
            {
                Console.WriteLine($" Digite o salario do {i} funcionario: ");
                salario [i] = double.Parse( Console.ReadLine() );

                soma += salario[i];
            }
            media = soma/50;
            Console.WriteLine ($" A média do salário dos 50 funcionarios é: {media}");








        }
    }
}
