using System;

namespace ExercicioSobreEstruturaSequencial3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            Console.WriteLine("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine($" diferença do produto de A e B pelo produto de C e D é de { diferenca}.");

        }
    }
}