using System;

class URI
{
    static void Main(string[] args)
    {
        string? frase = "";
        while ((frase = Console.ReadLine()) != "*")
        {
            if (!string.IsNullOrEmpty(frase))
            {
                string[] palavras = frase.Split(' ');

                char primeiraLetra = Char.ToUpper(palavras[0][0]);

                bool eTautograma = true;
                foreach (string palavra in palavras)
                {
                    if (Char.ToUpper(palavra[0]) != primeiraLetra)
                    {
                        eTautograma = false;
                        break;
                    }
                }

                Console.WriteLine(eTautograma ? "Y" : "N");
            }
        }
    }
}