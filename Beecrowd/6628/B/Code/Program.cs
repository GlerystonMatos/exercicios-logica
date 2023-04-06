using System;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        string? entrada = Console.ReadLine();

        if (!string.IsNullOrEmpty(entrada))
        {
            StringBuilder saida = new StringBuilder();
            bool remover = true;

            foreach (char letra in entrada.Trim())
            {
                if (letra != ' ')
                {
                    if (!remover)
                        saida.Append(letra);

                    remover = !remover;
                }
                else
                {
                    saida.Append(letra);
                }
            }

            Console.WriteLine(saida);

        }
    }
}