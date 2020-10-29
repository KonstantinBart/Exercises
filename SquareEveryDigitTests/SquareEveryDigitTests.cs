using NUnit.Framework;
namespace SquareEveryDigit.Tests
{
    [TestFixture()]
    public class SquareEveryDigitTests
    {
        [Test()]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(SquareEveryDigit.SquareDigits(9119), 811181);
        }
    }
}
