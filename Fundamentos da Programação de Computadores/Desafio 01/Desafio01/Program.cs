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

            double comprimentoCorda01 = Utilitarios.GetHipotenusa(alturaAsteEmMetros, comprimentoMetadePonte);
            double comprimentoCorda02 = Utilitarios.GetHipotenusa((alturaAsteEmMetros - espacoEntreCordasHaste), (comprimentoMetadePonte - espacoEntreCordasPonte));
            double comprimentoCorda03 = Utilitarios.GetHipotenusa((alturaAsteEmMetros - (espacoEntreCordasHaste * 2)), (comprimentoMetadePonte - (espacoEntreCordasPonte * 2)));
            double comprimentoCorda04 = Utilitarios.GetHipotenusa((alturaAsteEmMetros - (espacoEntreCordasHaste * 3)), (comprimentoMetadePonte - (espacoEntreCordasPonte * 3)));
            double comprimentoCorda05 = Utilitarios.GetHipotenusa((alturaAsteEmMetros - (espacoEntreCordasHaste * 4)), (comprimentoMetadePonte - (espacoEntreCordasPonte * 4)));

            double comprimentoTotalCordaLado01 = comprimentoCorda01 + comprimentoCorda02 + comprimentoCorda03 + comprimentoCorda04 + comprimentoCorda05;

            Console.WriteLine("");
            Console.WriteLine(string.Format("Comprimento ponte: {0} km ({1} m)", int.Parse(comprimento), string.Format("{0:n2}", comprimentoPonteEmMetros)));
            Console.WriteLine(string.Format("Altura haste (1/20 do comprimento total da ponte): {0} m", alturaAsteEmMetros));
            Console.WriteLine(string.Format("Comprimento da primeira corda: {0} m", string.Format("{0:n2}", comprimentoCorda01)));
            Console.WriteLine(string.Format("Comprimento da segunda corda: {0} m", string.Format("{0:n2}", comprimentoCorda02)));
            Console.WriteLine(string.Format("Comprimento da terceira corda: {0} m", string.Format("{0:n2}", comprimentoCorda03)));
            Console.WriteLine(string.Format("Comprimento da quarta corda: {0} m", string.Format("{0:n2}", comprimentoCorda04)));
            Console.WriteLine(string.Format("Comprimento da quinta corda: {0} m", string.Format("{0:n2}", comprimentoCorda05)));
            Console.WriteLine(string.Format("Comprimento total de corda para metade de um lado da ponte: {0} m", string.Format("{0:n2}", comprimentoTotalCordaLado01)));
            Console.WriteLine(string.Format("Comprimento total corda ponte (considerando os 4 lados): {0} m", string.Format("{0:n2}", (comprimentoTotalCordaLado01 * 4))));
        }
    }
}