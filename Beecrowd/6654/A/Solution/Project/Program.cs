class URI
{
    static void Main(string[] args)
    {
        IDictionary<char, int> valorAlfabeto = new Dictionary<char, int>();

        int valor = 0;
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            valorAlfabeto[letra] = valor;
            valor++;
        }

        int quantidadeCasosTeste = 0;
        int.TryParse(Console.ReadLine(), out quantidadeCasosTeste);

        for (int casoTeste = 0; casoTeste < quantidadeCasosTeste; casoTeste++)
        {
            int quantidadeLinhas = 0;
            int.TryParse(Console.ReadLine(), out quantidadeLinhas);

            int valorFinal = 0;
            for (int indiceLinha = 0; indiceLinha < quantidadeLinhas; indiceLinha++)
            {
                string? linha = Console.ReadLine();

                if (!string.IsNullOrEmpty(linha))
                {
                    for (int indiceLetra = 0; indiceLetra < linha.Length; indiceLetra++)
                    {
                        valorFinal += valorAlfabeto[linha[indiceLetra]] + indiceLinha + indiceLetra;
                    }
                }
            }

            Console.WriteLine(valorFinal);
        }
    }
}