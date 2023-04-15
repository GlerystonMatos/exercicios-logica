#pragma warning disable CS8600, CS8602
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string permuta = Console.ReadLine();
        string textoPermutado = Console.ReadLine();

        char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        IDictionary<char, char> dicionario = new Dictionary<char, char>();

        for (int indice = 0; indice < alfabeto.Length; indice++)
            dicionario.Add(permuta[indice], alfabeto[indice]);

        foreach (char letra in textoPermutado)
            Console.Write(dicionario[letra]);

        Console.WriteLine();
    }
}