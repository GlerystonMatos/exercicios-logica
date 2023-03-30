class URI
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        char[] letras = entrada.Trim().ToCharArray();

        string saida = "";
        bool remover = true;
        foreach (char letra in letras)
        {
            if (!letra.Equals(' '))
            {
                if (!remover)
                    saida += letra;

                remover = !remover;
            } else
            {
                saida += letra;
            }
        }

        Console.Write("{0}\n", saida);
    }
}