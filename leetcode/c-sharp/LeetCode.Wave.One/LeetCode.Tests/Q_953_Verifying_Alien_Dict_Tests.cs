using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests
{
    [TestClass]
    public class Q_953_Verifying_Alien_Dict_Tests
    {
        [TestMethod]
        public void Tests()
        {
            var isSorted = Q_0953_Verifying_Alien_Dict.IsAlienSorted(new string[] { "kuvp", "q" }, "ngxlkthsjuoqcpavbfdermiywz");

            Assert.IsTrue(isSorted);
        }
    }
}
