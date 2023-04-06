using System;

class URI
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];

        for (int indice = 0; indice < 10; indice++)
        {
            int.TryParse(Console.ReadLine(), out vetor[indice]);

            if (vetor[indice] <= 0)
            {
                vetor[indice] = 1;
            }
        }

        for (int indice = 0; indice < 10; indice++)
        {
            Console.WriteLine("X[" + indice + "] = " + vetor[indice]);
        }
    }
}