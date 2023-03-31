class URI
{
    static void Main(string[] args)
    {
        int quantidadePessoasFila = int.Parse(Console.ReadLine());

        IList<int> filaInicial = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int.Parse(Console.ReadLine());

        IList<int> sairamFila = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        IDictionary<int, int> dicionarioFilaInicial = new Dictionary<int, int>();
        for (int indice = 0; indice < quantidadePessoasFila; indice++)
        {
            dicionarioFilaInicial[filaInicial[indice]] = indice;
        }

        foreach (int indice in sairamFila)
        {
            filaInicial[dicionarioFilaInicial[indice]] = -1;
        }

        IList<int> novaFila = new List<int>();
        foreach (int indice in filaInicial)
        {
            if (indice != -1)
            {
                novaFila.Add(indice);
            }
        }

        Console.WriteLine(string.Join(" ", novaFila));
    }
}