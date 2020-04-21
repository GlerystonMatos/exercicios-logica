using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
            => Desafio04();

        static void Desafio04()
        {
            Console.WriteLine("Desafio 04 \n");

            Console.Write("Informe o número para ser convertido para binário: ");
            int numero = int.Parse(Console.ReadLine());

            string binario = "";
            while (numero > 0)
            {
                binario = (numero % 2) + binario;
                numero = numero / 2;
            }

            Console.WriteLine(string.Format("\nBinário: {0} ", binario));
        }
    }
}