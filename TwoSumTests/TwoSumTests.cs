using NUnit.Framework;

namespace TwoSum.Tests
{
    [TestFixture()]
    public class TwoSumTests
    {
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void ReverseTests(int[] sourceArray, int target, int[] result)
        {
            Assert.AreEqual(TwoSum.GetTwoSum(sourceArray, target), result);
        }
    }
}