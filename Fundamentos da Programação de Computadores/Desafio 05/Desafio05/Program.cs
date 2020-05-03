using System;

namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
            => Desafio05();

        static void Desafio05()
        {
            Console.WriteLine("Desafio 05 \n");

            Console.Write("Informe o valor do salário mínimo: ");
            double salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de L: ");
            double l = double.Parse(Console.ReadLine());

            double valorPorMetroQuadrado = ((10 * salarioMinimo) / 100);
            double areaQuarto = Math.Pow(l, 2);
            double areaBanheiro = (3.14 * Math.Pow(((l / 2) / 2), 2));
            double areaEscritorio = ((l * l) / 2);
            double areaSalas = ((4 * l) * (2 * l));
            double areaCopaCozinha = ((((2 * l) + l) / 2) * (l * 0.7));
            double areaCasa = ((4 * areaBanheiro) + (4 * areaQuarto) + areaEscritorio + areaSalas + areaCopaCozinha);
            double valorPedreiroCasa = (valorPorMetroQuadrado * areaCasa);
            double valorPedreiroCondominio = (valorPedreiroCasa * 40);

            Console.WriteLine(string.Format("\nValor por metro quadrado: R$ {0}", string.Format("{0:n2}", valorPorMetroQuadrado)));
            Console.WriteLine(string.Format("Areá de um quarto: {0} m2", string.Format("{0:n2}", areaQuarto)));
            Console.WriteLine(string.Format("Areá de um banheiro: {0} m2", string.Format("{0:n2}", areaBanheiro)));
            Console.WriteLine(string.Format("Areá de um escritório: {0} m2", string.Format("{0:n2}", areaEscritorio)));
            Console.WriteLine(string.Format("Areá das salas: {0} m2", string.Format("{0:n2}", areaSalas)));
            Console.WriteLine(string.Format("Areá da copa e cozinha: {0} m2", string.Format("{0:n2}", areaCopaCozinha)));
            Console.WriteLine(string.Format("Areá de uma casa: {0} m2", string.Format("{0:n2}", areaCasa)));
            Console.WriteLine(string.Format("Valor mão de obra de uma casa: R$ {0}", string.Format("{0:n2}", valorPedreiroCasa)));
            Console.WriteLine(string.Format("Valor mão de obra condomínio: R$ {0} ", string.Format("{0:n2}", valorPedreiroCondominio)));
        }
    }
}