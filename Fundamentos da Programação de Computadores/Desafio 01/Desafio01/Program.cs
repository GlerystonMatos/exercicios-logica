using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
            => Desafio01();

        static void Desafio01()
        {
            Console.Clear();
            Console.WriteLine("Desafio 01 \n");

            Console.Write("Digite o comprimento da ponte (comprimento deve estar entre 2 e 4 km): ");
            string comprimento = Console.ReadLine();

            int comprimentoPonteEmMetros = (int.Parse(comprimento) * 1000);
            int alturaAsteEmMetros = (comprimentoPonteEmMetros / 20);
            int espacoEntreCordasHaste = (alturaAsteEmMetros / 5);
            int comprimentoMetadePonte = (comprimentoPonteEmMetros / 2);
            int espacoEntreCordasPonte = (comprimentoMetadePonte / 5);

            Console.WriteLine("");
            Console.WriteLine("Comprimento ponte: {0} km ({1} m)", int.Parse(comprimento), string.Format("{0:n2}", comprimentoPonteEmMetros));
            Console.WriteLine("Altura haste (1/20 do comprimento total da ponte): {0} m", alturaAsteEmMetros);

            double comprimentoTotalCordaLado = 0;
            for (int contador = 0; contador <= 4; contador++)
            {
                double comprimentoCorda = GetHipotenusa((alturaAsteEmMetros - (espacoEntreCordasHaste * contador)), (comprimentoMetadePonte - (espacoEntreCordasPonte * contador)));
                Console.WriteLine("Comprimento da corda {0}: {1} m", (contador + 1), string.Format("{0:n2}", comprimentoCorda));
                comprimentoTotalCordaLado += comprimentoCorda;
            }

            Console.WriteLine("Comprimento total de corda para metade de um lado da ponte: {0} m", string.Format("{0:n2}", comprimentoTotalCordaLado));
            Console.WriteLine("Comprimento total corda ponte (considerando os 4 lados): {0} m", string.Format("{0:n2}", (comprimentoTotalCordaLado * 4)));
        }

        public static double GetHipotenusa(double cateto01, double cateto02)
            => Math.Sqrt(Math.Pow(cateto01, 2) + Math.Pow(cateto02, 2));
    }
}