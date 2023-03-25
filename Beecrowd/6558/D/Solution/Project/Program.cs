using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        IList<int> entradas = new List<int>();
        while (entradas.Count <= 9)
        {
            int valor = 0;
            int.TryParse(Console.ReadLine(), out valor);
            entradas.Add(valor);
        }

        int index = 0;
        IList<string> saidas = new List<string>();
        foreach (int entrada in entradas)
        {
            if (entrada <= 0)
            {
                saidas.Add("X[" + index + "] = 1");
            }
            else
            {
                saidas.Add("X[" + index + "] = " + entrada);
            }

            index += 1;
        }

        foreach (string saida in saidas)
        {
            Console.WriteLine("{0}", saida);
        }
    }
}