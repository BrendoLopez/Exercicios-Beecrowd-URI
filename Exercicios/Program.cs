using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        //Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos 
        //de um laboratório o qual ela é responsável.Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório 
        //e o percentual de cada tipo de cobaia utilizada.

        //Este laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos.Para obter estas informações,
        //ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada e a quantidade
        //de cobaias utilizadas em cada experimento.

        //Entrada ----->
        //A primeira linha de entrada contém um valor inteiro N que indica os vários casos de teste que vem a seguir.
        //Cada caso de teste contém um inteiro Quantia(1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas
        //e um caractere Tipo('C', 'R' ou 'S'), indicando o tipo de cobaia(R: Rato S: Sapo C: Coelho).

        //Saída <------
        //Apresente o total de cobaias utilizadas, o total de cada tipo de cobaia utilizada e o percentual de cada uma
        //em relação ao total de cobaias utilizadas, sendo que o percentual deve ser apresentado com dois dígitos após o ponto.

        int N = int.Parse(Console.ReadLine());

        int totalCobaias = 0;
        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos = 0;

        for (int i = 0; i < N; i++)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int quantidadeAnimal = int.Parse(vetor[0]);
            char tipoAnimal = char.Parse(vetor[1]);

            if (tipoAnimal == 'C')
            {
                totalCoelhos += quantidadeAnimal;
            }
            else if (tipoAnimal == 'R')
            {
                totalRatos += quantidadeAnimal;
            }
            else if (tipoAnimal == 'S')
            {
                totalSapos += quantidadeAnimal;
            }
            totalCobaias += quantidadeAnimal;
        }

        Console.WriteLine("Total: " + totalCobaias + " cobaias");
        Console.WriteLine("Total de coelhos: " + totalCoelhos);
        Console.WriteLine("Total de ratos: " + totalRatos);
        Console.WriteLine("Total de sapos: " + totalSapos);

        double percentualCoelhos = (double)totalCoelhos / totalCobaias * 100;
        double percentualRatos = (double)totalRatos / totalCobaias * 100;
        double percentualSapos = (double)totalSapos / totalCobaias * 100;

        Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
    }
}