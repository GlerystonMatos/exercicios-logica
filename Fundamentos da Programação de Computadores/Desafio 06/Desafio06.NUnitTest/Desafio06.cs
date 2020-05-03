using Desafios;
using NUnit.Framework;

namespace Desafio06.NUnitTest
{
    public class Tests
    {
        [Test]
        [TestCase(1, "Um")]
        [TestCase(5, "Cinco")]
        [TestCase(9, "Nove")]
        [TestCase(10, "Dez")]
        [TestCase(14, "Quatorze")]
        [TestCase(17, "Dezessete")]
        [TestCase(19, "Dezenove")]
        [TestCase(20, "Vinte")]
        [TestCase(28, "Vinte e oito")]
        [TestCase(40, "Quarenta")]
        [TestCase(43, "Quarenta e trés")]
        [TestCase(70, "Setenta")]
        [TestCase(76, "Setenta e seis")]
        [TestCase(90, "Noventa")]
        [TestCase(93, "Noventa e trés")]
        [TestCase(100, "Cem")]
        [TestCase(108, "Cento e oito")]
        [TestCase(130, "Cento e trinta")]
        [TestCase(159, "Cento e cinquenta e nove")]
        [TestCase(400, "Quatrocentos")]
        [TestCase(402, "Quatrocentos e dois")]
        [TestCase(470, "Quatrocentos e setenta")]
        [TestCase(446, "Quatrocentos e quarenta e seis")]
        [TestCase(600, "Seiscentos")]
        [TestCase(601, "Seiscentos e um")]
        [TestCase(650, "Seiscentos e cinquenta")]
        [TestCase(681, "Seiscentos e oitenta e um")]
        [TestCase(900, "Novecentos")]
        [TestCase(909, "Novecentos e nove")]
        [TestCase(920, "Novecentos e vinte")]
        [TestCase(915, "Novecentos e quinze")]
        [TestCase(1000, "Um mil")]
        [TestCase(1001, "Um mil e um")]
        [TestCase(1010, "Um mil e dez")]
        [TestCase(1100, "Um mil e cem")]
        [TestCase(1259, "Um mil e duzentos e cinquenta e nove")]
        [TestCase(1994, "Um mil e novecentos e noventa e quatro")]
        [TestCase(1845, "Um mil e oitocentos e quarenta e cinco")]
        [TestCase(1180, "Um mil e cento e oitenta")]
        [TestCase(3000, "Trés mil")]
        [TestCase(5000, "Cinco mil")]
        [TestCase(7000, "Sete mil")]
        [TestCase(10000, "Dez mil")]
        public void GetNumeroPorExtensoTest(int numero, string numeroPorExtenso)
            => Assert.IsTrue(Program.GetNumeroPorExtenso(numero).Equals(numeroPorExtenso));
    }
}