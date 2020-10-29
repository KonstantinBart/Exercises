using NUnit.Framework;

namespace ReverseInteger.Tests
{
    [TestFixture()]
    public class ReverseIntegerTests
    {
        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(0, 0)]
        public void ReverseTests(int source, int result)
        {
            Assert.AreEqual(ReverseInteger.Reverse(source), result);
        }
    }
}