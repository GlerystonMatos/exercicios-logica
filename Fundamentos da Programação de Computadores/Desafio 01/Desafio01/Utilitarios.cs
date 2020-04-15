using System;

namespace Desafios
{
    public class Utilitarios
    {
        public static double GetHipotenusa(double cateto01, double cateto02)
            => Math.Sqrt(Math.Pow(cateto01, 2) + Math.Pow(cateto02, 2));
    }
}