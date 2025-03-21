using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestEquals
{
    [TestMethod]
    public void Test_Equals()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(1, 2, 3, 4);
        Assert.IsTrue(m1.Equals(m2));
        Assert.AreEqual(m1.A, m2.A);
        Assert.AreEqual(m1.B, m2.B);
        Assert.AreEqual(m1.C, m2.C);
        Assert.AreEqual(m1.D, m2.D);
    }
    [TestMethod]
    public void Test_Equals_False()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(1, 2, 3, 5);
        Assert.IsFalse(m1.Equals(m2));
        Assert.AreEqual(m1.A, m2.A);
        Assert.AreEqual(m1.B, m2.B);
        Assert.AreEqual(m1.C, m2.C);
        Assert.AreNotEqual(m1.D, m2.D);
        var m3 = new Matrix2d(1, 2, 4, 4);
        Assert.IsFalse(m1.Equals(m3));
        Assert.AreEqual(m1.A, m3.A);
        Assert.AreEqual(m1.B, m3.B);
        Assert.AreNotEqual(m1.C, m3.C);
        Assert.AreEqual(m1.D, m3.D);
        var m4 = new Matrix2d(1, 3, 3, 4);
        Assert.IsFalse(m1.Equals(m4));
        Assert.AreEqual(m1.A, m4.A);
        Assert.AreNotEqual(m1.B, m4.B);
        Assert.AreEqual(m1.C, m4.C);
        Assert.AreEqual(m1.D, m4.D);
        var m5 = new Matrix2d(2, 2, 3, 4);
        Assert.IsFalse(m1.Equals(m5));
        Assert.AreNotEqual(m1.A, m5.A);
        Assert.AreEqual(m1.B, m5.B);
        Assert.AreEqual(m1.C, m5.C);
        Assert.AreEqual(m1.D, m5.D);
    }
    [TestMethod]
    public void Test_Equals_Null()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        Matrix2d m2 = null;
        Assert.IsFalse(m1.Equals(m2));
    }
}
