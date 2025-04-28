using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //· "Crie um programa que armazene as notas de 30 alunos e calcule a média da turma."

            double[] nota = new double[30];
            double soma = 0, media = 0;
            for (int i =0; i < 30; i++)
            {
                Console.WriteLine($" Digite a nota do {i} aluno: ");
                nota[i] = double.Parse(Console.ReadLine());
                soma += nota[i];
            }
            media = soma / 30;
            Console.WriteLine("A média dos 30 alunos é " + media);













        }
    }
}
