using System;

class URI
{
    static void Main(string[] args)
    {
        int quantidadeCasosTeste = int.Parse(Console.ReadLine());

        for (int contador = 0; contador < quantidadeCasosTeste; contador++)
        {
            string frase = Console.ReadLine().ToLower();

            int[] letras = new int[26];
            foreach (char letra in frase)
            {
                if (char.IsLetter(letra))
                {
                    letras[letra - 'a']++;
                }
            }

            int count = 0;
            foreach (int letra in letras)
            {
                if (letra > 0)
                {
                    count++;
                }
            }

            if (count == 26)
            {
                Console.WriteLine("frase completa");
            }
            else if (count >= 13)
            {
                Console.WriteLine("frase quase completa");
            }
            else
            {
                Console.WriteLine("frase mal elaborada");
            }
        }
    }
}