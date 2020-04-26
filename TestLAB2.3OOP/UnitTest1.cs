using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLAB2._3OOP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] {-5,3,5,-2};
            Assert.AreEqual(10, LAB2._3OOP.Program.NegativeMUlp(array));
            Assert.AreEqual(6, LAB2._3OOP.Program.Sumofneg(array));
        }
    }
}
