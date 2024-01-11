using System;
using System.Diagnostics.Metrics;
using System.Net;

class URI
{
    static void Main(string[] args)
    {
        // Sequência de Números e Soma
        // Exercício Beecrowd/URI 1101 - C#.

        //Leia um conjunto não determinado de pares de valores M e N(parar quando algum dos valores for menor ou igual a zero).
        //Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles(incluindo o N e M).

        //*Entrada
        //O arquivo de entrada contém um número não determinado de valores M e N.A última linha de entrada vai conter um número nulo ou negativo.

        //*Saída
        //Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.

        string[] vetor = Console.ReadLine().Split(' ');
        int M = int.Parse(vetor[0]);
        int N = int.Parse(vetor[1]);

        int soma = 0;
        while (M > 0 && N > 0)
        {
            int menor = Math.Min(M, N);
            int maior = Math.Max(M, M);

            vetor = Console.ReadLine().Split(' ');
            M = int.Parse(vetor[0]);
            N = int.Parse(vetor[1]);

            for (int i = menor; i <= maior; i++)
            {
                Console.Write(i + " ");
                soma += i;
            }
            Console.WriteLine($"Sum={soma}");
        }

        if (M <= 0 || N <= 0)
        {
            Console.WriteLine("M ou N menor ou igual a 0");
        }
    }
}