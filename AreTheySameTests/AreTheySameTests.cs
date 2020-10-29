using NUnit.Framework;

namespace AreTheySame.Tests
{
    [TestFixture()]
    public class AreTheySameTests
    {
        [TestCase(new[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 }, true)]
        [TestCase(new[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 }, false)]
        [TestCase(new[] { 121, 144, 19, 161, 19, 144, 19, 11 }, new[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 }, false)]
        [TestCase(new int[0], new int[0], false)]
        [TestCase(null, null, false)]
        public void AreTheySameArraysTests(int [] a, int [] b, bool result)
        {
            Assert.AreEqual(AreTheySame.comp(a, b), result);
        }
    }
}