using NUnit.Framework;

namespace PalindromeNumber.Tests
{
    [TestFixture()]
    public class SolutionTests
    {
        [TestCase(12321, true)]
        [TestCase(1221, true)]
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        [TestCase(-101, false)]
        [TestCase(0, true)]
        [TestCase(11, true)]
        public void IsPalindromeTest(int source, bool result)
        {
            Assert.AreEqual(Solution.IsPalindrome(source), result);
        }
    }
}