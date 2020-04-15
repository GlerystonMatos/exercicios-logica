using System;
using System.Collections.Generic;

namespace ExerciciosLogica
{
    class Program
    {
        static Peca[] Pecas;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Selecione o exercício que deseja realizar: \n");
            Console.WriteLine("Opções: 1.1, 1.2, 2.1, 2.2, 3.1 e 3.2 \n");
            string exercicio = Console.ReadLine();

            switch (exercicio)
            {
                case "1.1":
                    Exercicio11();
                    break;
                case "1.2":
                    Exercicio12();
                    break;
                case "2.1":
                    Exercicio21();
                    break;
                case "2.2":
                    Exercicio22();
                    break;
                case "3.1":
                    Exercicio31();
                    break;
                case "3.2":
                    Exercicio32();
                    break;
                default:
                    Console.WriteLine("Não foi localizado um exercício com esse código. \n");
                    break;
            }

            Continuar();
        }

        static void Continuar()
        {
            Console.WriteLine("");
            Console.Write("Deseja realizar outro exercício? (Sim / Não): ");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper().Equals("SIM"))
            {
                Console.Clear();
                Menu();
            }
        }

        static void Exercicio11()
        {
            Console.WriteLine(" \n");
            Console.WriteLine("Exercício 1.1 \n");

            Console.WriteLine("Digite as informações das peças \n");

            Pecas = new Peca[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Format("Peça {0} \n", (i + 1)));
                Console.WriteLine("Código, Quantidade e valor unitário \n");

                string[] texto = Console.ReadLine().Split(" ");
                Peca Peca = new Peca()
                {
                    Codigo = int.Parse(texto[0]),
                    Numero = int.Parse(texto[1]),
                    Valor = double.Parse(texto[2]),
                };

                Pecas[i] = Peca;

                Console.WriteLine("\n");
            }

            double Valor = 0;
            for (int i = 0; i < 2; i++)
            {
                Valor += (Pecas[i].Numero * Pecas[i].Valor);
            }

            Console.WriteLine(string.Format("VALOR A PAGAR: R$ {0}", string.Format("{0:n2}", Valor)));
        }

        static void Exercicio12()
        {
            Console.WriteLine(" \n");
            Console.WriteLine("Exercício 1.2 \n");

            Console.WriteLine("Digite o valor do raio do círculo: \n");
            double raio = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double area = (pi * (raio * raio));

            Console.WriteLine(" \n");
            Console.WriteLine(string.Format("A = {0}", string.Format("{0:n4}", area)));
        }

        static void Exercicio21()
        {
            Console.WriteLine(" \n");
            Console.WriteLine("Exercício 2.1 \n");

            Console.WriteLine("Digite o código do item: \n");
            int item = int.Parse(Console.ReadLine());

            Console.WriteLine(" \n");
            Console.WriteLine("Digite a quantidade de itens: \n");
            int quantidade = int.Parse(Console.ReadLine());

            double valor = 0;
            switch (item)
            {
                case 1:
                    valor = (quantidade * 4);
                    break;
                case 2:
                    valor = (quantidade * 4.50);
                    break;
                case 3:
                    valor = (quantidade * 5);
                    break;
                case 4:
                    valor = (quantidade * 2);
                    break;
                case 5:
                    valor = (quantidade * 1.50);
                    break;
                default:
                    Console.WriteLine("Item não localizado. \n");
                    break;
            }

            Console.WriteLine(" \n");
            Console.WriteLine(string.Format("Total: R$ {0}", string.Format("{0:n2}", valor)));
        }

        static void Exercicio22()
        {
            Console.WriteLine(" \n");
            Console.WriteLine("Exercício 2.2 \n");

            Console.WriteLine("Digite os valores dos coeficientes “a”, “b” e “c” separados por espaços: \n");
            string[] texto = Console.ReadLine().Split(" ");

            double a = double.Parse(texto[0]);
            double b = double.Parse(texto[1]);
            double c = double.Parse(texto[2]);

            if (a == 0.0)
            {
                Console.WriteLine(" \n");
                Console.WriteLine("Impossivel calcular \n");
            }
            else
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine(" \n");
                    Console.WriteLine("Impossivel calcular \n");
                }
                else
                {
                    double x1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
                    double x2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine(" \n");
                    Console.WriteLine(string.Format("X1 = {0}", string.Format("{0:n5}", x1)));
                    Console.WriteLine(string.Format("X2 = {0}", string.Format("{0:n5}", x2)));
                }
            }
        }

        static void Exercicio31()
        {
            Console.WriteLine(" \n");
            Console.WriteLine("Exercício 3.1 \n");

            bool valida = false;
            while (!valida)
            {
                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();

                valida = senha.Equals("2002");
                if (!valida)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Senha Invalida \n");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Acesso Permitido \n");
                }
            }
        }

        static void Exercicio32()
        {
            Console.WriteLine(" \n");
            Console.WriteLine("Exercício 3.2 \n");

            Console.Write("Digite a quantidade de valores que serão lidos: ");
            int quantidade = int.Parse(Console.ReadLine());

            IList<int> dentro = new List<int>();
            IList<int> fora = new List<int>();

            Console.WriteLine("");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(string.Format("{0}º Valor: ", i+1));
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    dentro.Add(valor);
                }
                else
                {
                    fora.Add(valor);
                }
            }

            Console.WriteLine("");
            Console.WriteLine(string.Format("{0} in", dentro.Count));
            Console.WriteLine(string.Format("{0} out", fora.Count));
        }
    }
}