class URI
{
    static void Main(string[] args)
    {
        int A = 0;
        int B = 0;

        int.TryParse(Console.ReadLine(), out A);
        int.TryParse(Console.ReadLine(), out B);

        int X = A + B;

        Console.Write("X = {0}\n", X);
    }
}