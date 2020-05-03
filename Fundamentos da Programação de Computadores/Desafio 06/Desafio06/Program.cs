using System;

namespace Desafios
{
    public class Program
    {
        static void Main(string[] args)
            => Desafio06();

        static void Desafio06()
        {
            Console.WriteLine("Desafio 06 \n");
            Console.WriteLine("Informe um número entre 1 e 10.000 \n");

            while (true)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if ((numero < 1) || (numero > 10000))
                {
                    Console.WriteLine("Número inválido \n");
                }
                else
                {
                    Console.WriteLine(GetNumeroPorExtenso(numero) + "\n");
                }
            }
        }

        public static string GetNumeroPorExtenso(int numero)
        {
            string numeroPorExtenso = "";
            switch (numero.ToString().Length)
            {
                case 1:
                    numeroPorExtenso = GetUnidadePorExtenso(numero);
                    break;
                case 2:
                    numeroPorExtenso = GetDezenaPorExtenso(numero);
                    break;
                case 3:
                    numeroPorExtenso = GetCentenaPorExtenso(numero);
                    break;
                case 4:
                case 5:
                    numeroPorExtenso = GetMilharPorExtenso(numero);
                    break;
            }

            if ((numeroPorExtenso.Length > 5) && (numeroPorExtenso.Substring(numeroPorExtenso.Length - 5, 5).Equals("cento")))
            {
                numeroPorExtenso = numeroPorExtenso.Replace("cento", "cem");
            }

            return numeroPorExtenso.Substring(0, 1).ToUpper() + numeroPorExtenso.Substring(1, numeroPorExtenso.Length - 1);
        }

        static int ExtrairNumero(int numero, int inicio, int fim)
        {
            try
            {
                return int.Parse(numero.ToString().Substring(inicio, fim));
            }
            catch
            {
                return 0;
            }
        }

        static string GetUnidadePorExtenso(int numero)
        {
            string[] unidades = new string[9] { "um", "dois", "trés", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            return (numero > 0) ? unidades[numero - 1] : "";
        }

        static string GetDezenaPorExtenso(int numero)
        {
            if (numero < 10)
            {
                return GetUnidadePorExtenso(numero);
            }
            else if (numero < 20)
            {
                return GetDezena01PorExtenso(numero);
            }
            else
            {
                string dezena = GetDezena02PorExtenso(ExtrairNumero(numero, 0, 1));
                string unidade = GetUnidadePorExtenso(ExtrairNumero(numero, 1, 1));
                return dezena + ((!string.IsNullOrEmpty(unidade)) ? " e " + unidade : "");
            }
        }

        static string GetDezena01PorExtenso(int numero)
        {
            string[] dezenas01 = new string[10] { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            return (numero > 0) ? dezenas01[numero - 10] : "";
        }

        static string GetDezena02PorExtenso(int numero)
        {
            string[] dezenas02 = new string[8] { "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            return (numero > 0) ? dezenas02[numero - 2] : "";
        }

        static string GetCentenaPorExtenso(int numero)
        {
            string[] centenas = new string[9] { "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            if (numero > 0)
            {
                string centena = (numero.ToString().Equals("100")) ? "cem" : centenas[ExtrairNumero(numero, 0, 1) - 1];
                string dezena = GetDezenaPorExtenso(ExtrairNumero(numero, 1, 2));
                centena += ((!string.IsNullOrEmpty(dezena)) ? " e " + dezena : "");
                return centena;
            }
            else
            {
                return "";
            }
        }

        static string GetMilharPorExtenso(int numero)
        {
            if (numero < 10000)
            {
                return GetMilhar01PorExtenso(numero);
            }
            else
            {
                return GetMilhar02PorExtenso(numero);
            }
        }

        static string GetMilhar01PorExtenso(int numero)
        {
            if (numero > 0)
            {
                string milhar = GetUnidadePorExtenso(ExtrairNumero(numero, 0, 1)) + " mil";
                string centena = GetCentenaPorExtenso(ExtrairNumero(numero, 1, 1));
                string dezena = GetDezenaPorExtenso(ExtrairNumero(numero, 2, 2));
                return GetMilhar03PorExtenso(milhar, centena, dezena);
            }
            else
            {
                return "";
            }
        }

        static string GetMilhar02PorExtenso(int numero)
        {
            if (numero > 0)
            {
                string milhar = GetDezenaPorExtenso(ExtrairNumero(numero, 0, 2)) + " mil";
                string centena = GetCentenaPorExtenso(ExtrairNumero(numero, 2, 1));
                string dezena = GetDezenaPorExtenso(ExtrairNumero(numero, 3, 2));
                return GetMilhar03PorExtenso(milhar, centena, dezena);
            }
            else
            {
                return "";
            }
        }

        static string GetMilhar03PorExtenso(string milhar, string centena, string dezena)
        {
            milhar += ((!string.IsNullOrEmpty(centena)) ? " e " + centena : "");
            milhar += ((!string.IsNullOrEmpty(dezena)) ? " e " + dezena : "");
            return milhar;
        }
    }
}