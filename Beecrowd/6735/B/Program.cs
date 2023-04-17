#pragma warning disable
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeEntradas = int.Parse(Console.ReadLine());

        StringBuilder permuta = new StringBuilder();
        HashSet<string> permutacoes = new HashSet<string>();

        for (int entrada = 0; entrada < quantidadeEntradas; entrada++)
        {
            char[] textoArray = Console.ReadLine().ToCharArray();
            Array.Sort(textoArray);
            permutacoes.Clear();

            int fatorialPossibilidades = 1;
            for (int item = 2; item <= textoArray.Length; item++)
                fatorialPossibilidades *= item;

            while (fatorialPossibilidades-- > 0)
            {
                permuta.Clear();
                permuta.Append(textoArray);
                permutacoes.Add(permuta.ToString());

                int indiceBase = textoArray.Length - 2;
                while (indiceBase >= 0 && textoArray[indiceBase] >= textoArray[indiceBase + 1])
                    indiceBase--;

                if (indiceBase < 0)
                    break;

                int indiceMaior = textoArray.Length - 1;
                while (textoArray[indiceBase] >= textoArray[indiceMaior])
                    indiceMaior--;

                char textoTemporario = textoArray[indiceBase];
                textoArray[indiceBase] = textoArray[indiceMaior];
                textoArray[indiceMaior] = textoTemporario;

                int indiceEsquerda = indiceBase + 1;
                indiceMaior = textoArray.Length - 1;

                while (indiceEsquerda < indiceMaior)
                {
                    textoTemporario = textoArray[indiceEsquerda];
                    textoArray[indiceEsquerda] = textoArray[indiceMaior];
                    textoArray[indiceMaior] = textoTemporario;

                    indiceEsquerda++;
                    indiceMaior--;
                }
            }

            foreach (string item in permutacoes)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }
}