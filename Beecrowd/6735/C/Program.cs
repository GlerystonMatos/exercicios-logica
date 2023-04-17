#pragma warning disable
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] entrada = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int quantidadePinos = entrada[0];
        int alturaPinos = entrada[1];

        int[] fechadura = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int movimentos = 0;
        for (int indice = 0; indice < (quantidadePinos - 1); indice++)
        {
            int diferenca = alturaPinos - fechadura[indice];
            fechadura[indice] += diferenca;
            fechadura[indice + 1] += diferenca;
            movimentos += Math.Abs(diferenca);
        }

        Console.WriteLine(movimentos);
    }
}