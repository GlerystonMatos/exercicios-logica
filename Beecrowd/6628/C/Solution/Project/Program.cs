class URI
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        string[] valores = entrada.Trim().Split(' ');

        int p1 = int.Parse(valores[0]);
        int c1 = int.Parse(valores[1]);
        int p2 = int.Parse(valores[2]);
        int c2 = int.Parse(valores[3]);

        int esquerda = p1 * c1;
        int direita = p2 * c2;

        if (esquerda == direita)
            Console.Write("{0}\n", 0);
        else if (esquerda > direita)
            Console.Write("{0}\n", -1);
        else
            Console.Write("{0}\n", 1);
    }
}