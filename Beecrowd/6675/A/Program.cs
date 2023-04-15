#pragma warning disable CS8602
using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        int[] casas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] encomendas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int tempo = 0;
        int ultimaEntrega = casas[0];

        Dictionary<int, int> indiceCasas = casas
            .Select((value, index) => new { value, index })
            .ToDictionary(c => c.value, c => c.index);

        foreach (int encomenda in encomendas)
        {
            int indiceCasa = indiceCasas[encomenda];

            if (indiceCasa > indiceCasas[ultimaEntrega])
                tempo += indiceCasa - indiceCasas[ultimaEntrega];
            else
                tempo += indiceCasas[ultimaEntrega] - indiceCasa;

            ultimaEntrega = encomenda;
        }

        Console.WriteLine(tempo);
    }
}