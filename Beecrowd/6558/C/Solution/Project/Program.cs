using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        IList<string> entradas = new List<string>();
        while (true)
        {
            string frase = Console.ReadLine();
            if (!frase.Equals("*"))
            {
                entradas.Add(frase);
            }
            else
            {
                break;
            }
        }

        IList<string> saidas = new List<string>();
        foreach (string frase in entradas)
        {
            char inicial = ' ';
            string tautograma = "Y";
            string[] palavras = frase.Split(' ');

            foreach (string palavra in palavras)
            {
                char[] letras = palavra.ToUpper().ToCharArray();
                if (inicial.Equals(' '))
                    inicial = letras[0];

                if (!inicial.Equals(letras[0]))
                {
                    tautograma = "N";
                    break;
                }
            }

            saidas.Add(tautograma);
        }

        foreach (string tautograma in saidas)
        {
            Console.WriteLine("{0}", tautograma);
        }
    }
}