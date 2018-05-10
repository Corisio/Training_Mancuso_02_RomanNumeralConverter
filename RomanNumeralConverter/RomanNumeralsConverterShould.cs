using NUnit.Framework;
using RomanNumeralConverter;

namespace SandroMancusoTraining_Project2
{
    [TestFixture]
    public class RomanNumeralsConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(16, "XVI")]
        [TestCase(20, "XX")]
        [TestCase(21, "XXI")]
        [TestCase(32, "XXXII")]
        [TestCase(50, "L")]
        [TestCase(86, "LXXXVI")]
        [TestCase(100, "C")]
        [TestCase(166, "CLXVI")]
        [TestCase(500, "D")]
        [TestCase(666, "DCLXVI")]
        [TestCase(1000, "M")]
        [TestCase(1666, "MDCLXVI")]
        [TestCase(4, "IV")]
        [TestCase(99, "XCIX")]
        [TestCase(993, "CMXCIII")] 
        public void ReturnTheExpectedRomanNumeral(int sourceValue, string expectedValue)
        {
            var converter = new RomanNumeralsConverter();
            Assert.AreEqual(expectedValue, converter.Convert(sourceValue));
        }
    }
}
