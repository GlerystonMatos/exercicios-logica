#pragma warning disable
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int casosTeste = int.Parse(Console.ReadLine());

        for (int casoTeste = 1; casoTeste <= casosTeste; casoTeste++)
        {
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            string[] arvoreArray = Console.ReadLine().Split();
            Arvore arvore = new Arvore(int.Parse(arvoreArray[0]));

            for (int index = 1; index < quantidadeNumeros; index++)
                arvore.Inserir(int.Parse(arvoreArray[index]));

            Console.WriteLine($"Case {casoTeste}:");
            Console.WriteLine($"Pre.: {string.Join(" ", arvore.PreOrdem())}");
            Console.WriteLine($"In..: {string.Join(" ", arvore.EmOrdem())}");
            Console.WriteLine($"Post: {string.Join(" ", arvore.PosOrdem())}");
            Console.WriteLine();
        }
    }
}

class Arvore
{
    public int No;

    public Arvore Esquerda;

    public Arvore Direita;

    public Arvore(int valor)
    {
        No = valor;
        Direita = null;
        Esquerda = null;
    }

    public void Inserir(int valor)
    {
        if (valor < No)
        {
            if (Esquerda == null)
                Esquerda = new Arvore(valor);
            else
                Esquerda.Inserir(valor);
        }
        else
        {
            if (Direita == null)
                Direita = new Arvore(valor);
            else
                Direita.Inserir(valor);
        }
    }

    public List<int> PreOrdem()
    {
        List<int> retorno = new List<int> { No };
        if (Esquerda != null)
            retorno.AddRange(Esquerda.PreOrdem());

        if (Direita != null)
            retorno.AddRange(Direita.PreOrdem());

        return retorno;
    }

    public List<int> EmOrdem()
    {
        List<int> retorno = new List<int>();
        if (Esquerda != null)
            retorno.AddRange(Esquerda.EmOrdem());

        retorno.Add(No);

        if (Direita != null)
            retorno.AddRange(Direita.EmOrdem());

        return retorno;
    }

    public List<int> PosOrdem()
    {
        List<int> retorno = new List<int>();
        if (Esquerda != null)
            retorno.AddRange(Esquerda.PosOrdem());

        if (Direita != null)
            retorno.AddRange(Direita.PosOrdem());

        retorno.Add(No);
        return retorno;
    }
}