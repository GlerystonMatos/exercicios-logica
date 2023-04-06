using System;

class URI
{
    static void Main(string[] args)
    {
        int A = 0, B = 0, X = 0;

        int.TryParse(Console.ReadLine(), out A);
        int.TryParse(Console.ReadLine(), out B);

        X += A;
        X += B;

        Console.WriteLine("X = {0}", X);
    }
}