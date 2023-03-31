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

        int quantidadeCasosTeste = int.Parse(Console.ReadLine());

        for (int casoTeste = 0; casoTeste < quantidadeCasosTeste; casoTeste++)
        {
            int quantidadeLinhas = int.Parse(Console.ReadLine());
            int valorFinal = 0;

            for (int indiceLinha = 0; indiceLinha < quantidadeLinhas; indiceLinha++)
            {
                string linha = Console.ReadLine();

                for (int indiceLetra = 0; indiceLetra < linha.Length; indiceLetra++)
                {
                    valorFinal += valorAlfabeto[linha[indiceLetra]] + indiceLinha + indiceLetra;
                }
            }

            Console.WriteLine(valorFinal);
        }
    }
}