using NUnit.Framework;

namespace SandroMancusoTraining_Project2
{
    [TestFixture]
    public class RomanNumeralsConverterShould
    {
        [TestCase(1, "I")]
        //[TestCase(2, "II")]
        //[TestCase(3, "III")]
        public void ReturnAsManyIAsTheReceivedNumber_WhenItIsLowerThanFour(int sourceValue, string expectedValue)
        {
            var converter = new RomanNumeralsConverter();
            Assert.AreEqual(expectedValue, converter.Convert(sourceValue));
        }
    }
}
