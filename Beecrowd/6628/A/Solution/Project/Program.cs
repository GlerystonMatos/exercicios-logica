class URI
{
    static void Main(string[] args)
    {
        int quantidade = 0;
        IList<int> quantidadeDiamantes = new List<int>();
        int.TryParse(Console.ReadLine(), out quantidade);

        for (int casoTeste = 0; casoTeste < quantidade; casoTeste++)
        {
            string valor = Console.ReadLine();
            char[] valores = valor.Trim().ToCharArray();

            int diamantes = 0;
            int fechamento = 0;
            int inicioDiamante = 0;

            for (int contador = 0; contador < valores.Length; contador++)
            {
                if (valores[contador] == '<')
                    inicioDiamante += 1;
                else if (valores[contador] == '>' && inicioDiamante > 0)
                {
                    inicioDiamante -= 1;
                    diamantes += 1;
                }
            }

            quantidadeDiamantes.Add(diamantes);
        }

        foreach (int diamantes in quantidadeDiamantes)
        {
            Console.Write("{0}\n", diamantes);
        }
    }
}