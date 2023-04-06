using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        int quantidadePessoasFila = int.Parse(Console.ReadLine());

        int[] fila = new int[quantidadePessoasFila];
        string[] entrada = Console.ReadLine().Split();

        for (int indice = 0; indice < quantidadePessoasFila; indice++)
        {
            fila[indice] = int.Parse(entrada[indice]);
        }

        int quantidadePessoasSairam = int.Parse(Console.ReadLine());
        HashSet<int> sairam = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

        IList<int> novaFila = new List<int>();
        for (int indice = 0; indice < quantidadePessoasFila; indice++)
        {
            if (!sairam.Contains(fila[indice]))
            {
                novaFila.Add(fila[indice]);
            }
        }

        Console.WriteLine(string.Join(" ", novaFila));
    }
}