#pragma warning disable CS8602
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dimensoesMatriz = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int quantidadeLinhas = dimensoesMatriz[0];
        int quantidadeColunas = dimensoesMatriz[1];

        int[][] matriz = new int[quantidadeLinhas][];
        for (int linha = 0; linha < quantidadeLinhas; linha++)
            matriz[linha] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        bool eEscada = true;
        for (int linha = 0; linha < quantidadeLinhas; linha++)
        {
            bool apenasZeros = true;
            int primeiraColunaValida = -1;

            for (int coluna = 0; coluna < quantidadeColunas; coluna++)
            {
                if (matriz[linha][coluna] != 0)
                {
                    apenasZeros = false;
                    if (primeiraColunaValida == -1)
                    {
                        primeiraColunaValida = coluna;
                        break;
                    }
                }
            }

            if (apenasZeros)
            {
                for (int proximaLinha = (linha + 1); proximaLinha < quantidadeLinhas; proximaLinha++)
                {
                    bool apenasZerosAbaixo = true;
                    for (int coluna = 0; coluna < quantidadeColunas; coluna++)
                    {
                        if (matriz[proximaLinha][coluna] != 0)
                        {
                            apenasZerosAbaixo = false;
                            break;
                        }
                    }
                    if (!apenasZerosAbaixo)
                    {
                        eEscada = false;
                        break;
                    }
                }
            }
            else
            {
                if ((primeiraColunaValida == -1) || (matriz[linha][primeiraColunaValida] == 0))
                {
                    eEscada = false;
                    break;
                }
                else
                {
                    for (int proximaLinha = (linha + 1); proximaLinha < quantidadeLinhas; proximaLinha++)
                    {
                        bool temValorDiferenteZero = false;
                        for (int coluna = 0; coluna <= primeiraColunaValida; coluna++)
                        {
                            if (matriz[proximaLinha][coluna] != 0)
                            {
                                temValorDiferenteZero = true;
                                break;
                            }
                        }

                        if (temValorDiferenteZero)
                        {
                            eEscada = false;
                            break;
                        }
                    }
                }
            }
        }

        Console.WriteLine(eEscada ? "S" : "N");
    }
}