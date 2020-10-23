using NUnit.Framework;

namespace TwoSum.Tests
{
    [TestFixture()]
    public class TwoSumTests
    {
        [Test()]
        public void ReverseTests()
        {
            Assert.AreEqual(TwoSum.GetTwoSum(new[] { 2, 7, 11, 15 }, 9), new[] { 0, 1 } );
            Assert.AreEqual(TwoSum.GetTwoSum(new[] { 3, 2, 4 }, 6), new[] { 1, 2 } );
            Assert.AreEqual(TwoSum.GetTwoSum(new[] { 3, 3 }, 6), new[] { 0, 1 });
        }
    }
}