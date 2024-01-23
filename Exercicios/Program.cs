using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < N.Length; i++)
            {
                N[i] = rnd.Next(0, 100);
            }

            int contador = 0;
            int temp = 0;
            int decrescente = 19;
            for (int j = N.Length / 2; j >= 0; j--)
            {
                temp = N[decrescente];
                N[decrescente] = N[contador];
                N[contador] = temp;
                decrescente--;
                contador++;
            }

            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {N[i]}");
            }
        }
    }
}