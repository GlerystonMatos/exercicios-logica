using System;

class URI
{
    static void Main(string[] args)
    {
        int quantidadeCasosTeste = 0;
        int.TryParse(Console.ReadLine(), out quantidadeCasosTeste);

        for (int indice = 0; indice < quantidadeCasosTeste; indice++)
        {
            string? entrada = Console.ReadLine();
            if (!string.IsNullOrEmpty(entrada))
            {
                int quantidadeDiamantes = 0;
                int diamantesAbertos = 0;

                foreach (char valor in entrada)
                {
                    if (valor == '<')
                    {
                        diamantesAbertos++;
                    }
                    else if (valor == '>' && diamantesAbertos > 0)
                    {
                        quantidadeDiamantes++;
                        diamantesAbertos--;
                    }
                }

                Console.WriteLine(quantidadeDiamantes);
            }
        }
    }
}