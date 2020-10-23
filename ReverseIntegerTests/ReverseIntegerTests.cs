using NUnit.Framework;

namespace ReverseInteger.Tests
{
    [TestFixture()]
    public class ReverseIntegerTests
    {
        [Test()]
        public void ReverseTests()
        {
            Assert.AreEqual(ReverseInteger.Reverse(123), 321);
            Assert.AreEqual(ReverseInteger.Reverse(-123), -321);
            Assert.AreEqual(ReverseInteger.Reverse(120), 21);
            Assert.AreEqual(ReverseInteger.Reverse(0), 0);
        }
    }
}