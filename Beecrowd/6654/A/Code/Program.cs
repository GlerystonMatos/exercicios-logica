using System;
using System.Collections.Generic;

class URI
{
    public static void Main(string[] args)
    {
        IDictionary<char, int> valorAlfabeto = GetDicionarioAlfabeto();

        int quantidadeCasosTeste = int.Parse(Console.ReadLine());
        for (int indice = 0; indice < quantidadeCasosTeste; indice++)
        {
            int valorHash = 0;

            int quantidadeLinhas = int.Parse(Console.ReadLine());
            for (int indiceLinha = 0; indiceLinha < quantidadeLinhas; indiceLinha++)
            {
                string linha = Console.ReadLine();
                for (int indiceLetra = 0; indiceLetra < linha.Length; indiceLetra++)
                {
                    valorHash += valorAlfabeto[linha[indiceLetra]] + indiceLinha + indiceLetra;
                }
            }

            Console.WriteLine(valorHash);
        }
    }

    public static IDictionary<char, int> GetDicionarioAlfabeto()
    {
        IDictionary<char, int> valorAlfabeto = new Dictionary<char, int>();

        int valor = 0;
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            valorAlfabeto[letra] = valor;
            valor++;
        }

        return valorAlfabeto;
    }
}