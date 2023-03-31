class URI
{
    static void Main(string[] args)
    {
        int quantidadeCasosTeste = int.Parse(Console.ReadLine());

        for (int contador = 0; contador < quantidadeCasosTeste; contador++)
        {
            string frase = Console.ReadLine().ToLower();

            ICollection<char> letras = new HashSet<char>(frase);
            letras.Remove(' ');
            letras.Remove(',');

            if (letras.Count == 26)
            {
                Console.WriteLine("frase completa");
            }
            else if (letras.Count >= 13)
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