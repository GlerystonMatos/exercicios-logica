using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
            => Desafio03();

        static void Desafio03()
        {
            Console.Clear();
            Console.WriteLine("Desafio 03 \n");

            Console.Write("Informe o ângulo da escada com o chão (em graus): ");
            string anguloComChao = Console.ReadLine();

            Console.Write("Informe a altura desejada (em metros): ");
            string alturaDesejada = Console.ReadLine();

            double anguloA = double.Parse(anguloComChao);
            double alturaCentimetros = (double.Parse(alturaDesejada) * 100);
            double senoUmGrau = 0.017452;
            double senoAnguloA = (anguloA * senoUmGrau);
            double hipotenusa = (senoAnguloA * alturaCentimetros);
            double quantidadeDegrausEscada = (hipotenusa / 30);

            Console.WriteLine("");
            Console.WriteLine(string.Format("Tamanho da escada: {0} m (centimetros)", string.Format("{0:n6}", hipotenusa)));
            Console.WriteLine(string.Format("Quantidade de degraus: {0}", string.Format("{0:n6}", quantidadeDegrausEscada)));
            Console.WriteLine(string.Format("Quantidade de degraus aproximadamente: {0}", Math.Round(quantidadeDegrausEscada)));
            Console.WriteLine("");
            Console.Write("Tabelas trigonométrica: https://brasilescola.uol.com.br/matematica/seno-cosseno-tangente-angulos.htm");
            Console.WriteLine("");
        }
    }
}