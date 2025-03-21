using Matrix2dLib;

namespace Matrix2dTest
{
    [TestClass]
    public sealed class Matrix2dTestConstructor
    {
        [TestMethod]
        public void Test_Full_constructor()
        {
            var m = new Matrix2d(1, 2, 3, 4);

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(2, m.B);
            Assert.AreEqual(3, m.C);
            Assert.AreEqual(4, m.D);
        }
        [TestMethod]
        public void Test_Empty_Constructor()
        {
            var m = new Matrix2d();

            Assert.AreEqual(1, m.A);
            Assert.AreEqual(0, m.B);
            Assert.AreEqual(0, m.C);
            Assert.AreEqual(1, m.D);
        }
    }
}
