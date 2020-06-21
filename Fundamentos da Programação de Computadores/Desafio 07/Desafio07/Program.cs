using System;

namespace Desafios
{
    public class Program
    {
        public static void Main(string[] args)
            => Desafio07();

        public static void Desafio07()
        {
            string[,] palavras = new string[10, 2]
            {
                { "Alan Turing", "Pai da computação." },
                { "Albert Einstein", "Elaborou a teoria geral da relatividade." },
                { "Projeto Manhattan", "Programa de pesquisa e desenvolvimento que produziu as primeiras bombas atômicas." },
                { "Edward Teach", "Mais conhecido como barba negra, foi um pirata inglês." },
                { "Jimi Hendrix", "Foi um guitarrista, cantor e compositor norte-americano." },
                { "Stephen Hawking", "Físico teórico e cosmólogo britânico reconhecido internacionalmente." },
                { "Fossa das Marianas", "Local mais profundo dos oceanos." },
                { "Megalodon", "Foi uma espécie de tubarão gigante que viveu entre 23 e 2,6 milhões de anos atrás." },
                { "Monte Everest", "É a montanha de maior altitude da Terra. " },
                { "Caldeira de Yellowstone", "Caldeira vulcânica situada no Parque Nacional de Yellowstone." }
            };

            string[] letrasUtilizadas = new string[26] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

            int palavraEscolhida = new Random().Next(1, 10);
            int quantidadeLetrasPalavra = palavras[palavraEscolhida - 1, 0].Length;
            int letrasInformadas = 0;
            int quantidadeChances = 0;
            bool continuarJogando = true;
            string letraJaInformada = "";

            while (continuarJogando)
            {
                ImpimirDesafio();
                ImpimirDica(quantidadeChances, palavras, palavraEscolhida);
                ImprimirLetras(quantidadeLetrasPalavra, palavras, palavraEscolhida, letrasUtilizadas);
                ImprimirEspacoLetras(quantidadeLetrasPalavra, palavras, palavraEscolhida);
                ImprimirLetrasUtilizadas(letrasUtilizadas);
                ImprimeChancesUtilizadas(quantidadeChances);

                if (quantidadeChances == 7)
                {
                    continuarJogando = ImpimirMaximoTentativas(palavras, palavraEscolhida);
                }
                else
                {
                    continuarJogando = ImprimirProximaJogada(palavras, palavraEscolhida, letrasUtilizadas, ref letrasInformadas, ref quantidadeChances, ref letraJaInformada);
                }
            }
        }

        public static void ImpimirDesafio()
        {
            Console.Clear();
            Console.WriteLine("Desafio 07 \n");
        }

        public static bool ImpimirMaximoTentativas(string[,] palavras, int palavraEscolhida)
        {
            Console.WriteLine("\n\nNúmero máximo de tentativas excedidas.");

            Console.Write("\nArisque a resposta: ");
            string resposta = Console.ReadLine();
            return VerificarResposta(resposta, palavras, palavraEscolhida);
        }

        public static bool ImprimirProximaJogada(string[,] palavras, int palavraEscolhida, string[] letrasUtilizadas, ref int letrasInformadas, ref int quantidadeChances, ref string letraJaInformada)
        {
            if (!string.IsNullOrEmpty(letraJaInformada))
            {
                Console.Write(string.Format("\n\n{0}\n", letraJaInformada));
            }
            else
            {
                Console.Write("\n");
            }

            Console.Write("\nInforme uma letra ou arisque a resposta: ");
            string resposta = Console.ReadLine();

            if (resposta.Length.Equals(1))
            {
                if (LetraJaInformada(resposta, letrasUtilizadas))
                {
                    letraJaInformada = string.Format("A letra {0} já foi informada.", resposta);
                    return true;
                }
                else
                {
                    letrasUtilizadas[letrasUtilizadas.Length - (26 - letrasInformadas)] = resposta;
                    letrasInformadas += 1;
                    quantidadeChances += 1;
                    letraJaInformada = "";
                    return true;
                }
            }
            else
            {
                return VerificarResposta(resposta, palavras, palavraEscolhida);
            }
        }

        public static bool LetraJaInformada(string resposta, string[] letrasUtilizadas)
        {
            bool achou = false;
            for (int i = 0; i < (letrasUtilizadas.Length - 1); i++)
            {
                if (!string.IsNullOrEmpty(letrasUtilizadas[i]))
                {
                    if (letrasUtilizadas[i].ToString().ToUpper().Equals(resposta))
                    {
                        achou = true;
                        break;
                    }
                }
            }

            return achou;
        }

        public static void ImpimirDica(int quantidadeChances, string[,] palavras, int palavraEscolhida)
        {
            if (quantidadeChances >= 6)
            {
                Console.WriteLine(string.Format("Dica: {0}\n", palavras[palavraEscolhida - 1, 1]));
            }
        }

        public static void ImprimirLetras(int quantidadeLetrasPalavra, string[,] palavras, int palavraEscolhida, string[] letrasUtilizadas)
        {
            for (int i = 0; i < quantidadeLetrasPalavra; i++)
            {
                bool achou = false;
                for (int j = 0; j < (letrasUtilizadas.Length - 1); j++)
                {
                    if (!string.IsNullOrEmpty(letrasUtilizadas[j]))
                    {
                        if (palavras[palavraEscolhida - 1, 0].ToUpper()[i].ToString().Equals(letrasUtilizadas[j].ToString().ToUpper()))
                        {
                            Console.Write(string.Format("  {0}  ", letrasUtilizadas[j].ToString().ToUpper()));
                            achou = true;
                            break;
                        }
                    }
                }

                if (!achou)
                {
                    Console.Write("     ");
                }
            }
        }

        public static void ImprimirEspacoLetras(int quantidadeLetrasPalavra, string[,] palavras, int palavraEscolhida)
        {
            Console.WriteLine("");
            for (int i = 0; i < quantidadeLetrasPalavra; i++)
            {
                if (palavras[palavraEscolhida - 1, 0].ToUpper()[i].ToString().Trim().Equals(""))
                {
                    Console.Write("     ");
                }
                else
                {
                    Console.Write(" ___ ");
                }
            }
        }

        public static void ImprimirLetrasUtilizadas(string[] letrasUtilizadas)
        {
            Console.Write("\n\nLetras já utilizadas: ");

            for (int i = 0; i < (letrasUtilizadas.Length - 1); i++)
            {
                if (!letrasUtilizadas[i].Equals(""))
                {
                    Console.Write(string.Format(" {0} ", letrasUtilizadas[i].ToString().ToUpper()));
                }
            }
        }

        public static void ImprimeChancesUtilizadas(int quantidadeChances)
        {
            Console.Write(string.Format("\n\nChance já utilizadas: ({0}/7) ", quantidadeChances));
        }

        public static bool VerificarResposta(string resposta, string[,] palavras, int palavraEscolhida)
        {
            ImpimirDesafio();

            if (resposta.ToUpper().Equals(palavras[palavraEscolhida - 1, 0].ToUpper()))
            {
                Console.WriteLine(string.Format("A resposta está correta: {0}", palavras[palavraEscolhida - 1, 0]));
            }
            else
            {
                Console.WriteLine("A resposta está errada.");
                Console.WriteLine(string.Format("A resposta correta é: {0}", palavras[palavraEscolhida - 1, 0]));
            }

            Console.Write("\nDesejá continuar? (S/N) ");
            string continuar = Console.ReadLine();

            bool continuarJogando = true;
            if (continuar.ToUpper().Equals("S"))
            {
                Desafio07();
            }
            else
            {
                continuarJogando = false;
            }

            return continuarJogando;
        }
    }
}