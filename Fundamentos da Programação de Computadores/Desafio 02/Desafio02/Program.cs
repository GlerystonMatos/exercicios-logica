using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
            => Desafio02();

        static void Desafio02()
        {
            Console.Clear();
            Console.WriteLine("Desafio 02 \n");

            Console.Write("Informe o diâmetro do círculo maior: ");
            string valorLido = Console.ReadLine();

            double diametroCirculoMaior = double.Parse(valorLido);
            double raioCirculoMaior = (diametroCirculoMaior / 2);
            double espacoEntreCirculos = (raioCirculoMaior / 6);
            double areaTotalAlvo = 0;

            for (int contador = 0; contador < 6; contador++)
            {
                double diametroCirculo = diametroCirculoMaior - ((espacoEntreCirculos * 2) * contador);
                double raioCirculo = (diametroCirculo / 2);
                double areaCirculo = (3.14 * Math.Pow(raioCirculo, 2));
                areaTotalAlvo += areaCirculo;
            }

            Console.WriteLine("");
            Console.WriteLine(string.Format("Papelão necessário para um alvo: {0} cm2 (Centímetros quadrados)", string.Format("{0:n2}", areaTotalAlvo)));
            Console.WriteLine(string.Format("Papelão necessário para 5000 alvos: {0} cm2 (Centímetros quadrados)", string.Format("{0:n2}", areaTotalAlvo * 5000)));
        }
    }
}