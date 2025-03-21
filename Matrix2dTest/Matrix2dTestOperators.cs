using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestOperators
{
    [TestMethod]
    public void Test_Operator_Equal()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(1, 2, 3, 4);
        Assert.IsTrue(m1 == m2);
    }
    [TestMethod]
    public void Test_Operator_Not_Equal()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(1, 2, 3, 5);
        Assert.IsTrue(m1 != m2);
    }
    [TestMethod]
    public void Test_Operator_Add()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(5, 6, 7, 8);
        var m3 = m1 + m2;
        Assert.AreEqual(6, m3.A);
        Assert.AreEqual(8, m3.B);
        Assert.AreEqual(10, m3.C);
        Assert.AreEqual(12, m3.D);
        Assert.AreEqual(m1.A + m2.A, m3.A);
        Assert.AreEqual(m1.B + m2.B, m3.B);
        Assert.AreEqual(m1.C + m2.C, m3.C);
        Assert.AreEqual(m1.D + m2.D, m3.D);
    }
    [TestMethod]
    public void Test_Operator_Subtract()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(5, 6, 7, 8);
        var m3 = m1 - m2;
        Assert.AreEqual(-4, m3.A);
        Assert.AreEqual(-4, m3.B);
        Assert.AreEqual(-4, m3.C);
        Assert.AreEqual(-4, m3.D);
        Assert.AreEqual(m1.A - m2.A, m3.A);
        Assert.AreEqual(m1.B - m2.B, m3.B);
        Assert.AreEqual(m1.C - m2.C, m3.C);
        Assert.AreEqual(m1.D - m2.D, m3.D);
    }
    [TestMethod]
    public void Test_Operator_Multiply_Matrixes()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(5, 6, 7, 8);
        var m3 = m1 * m2;
        Assert.AreEqual(19, m3.A);
        Assert.AreEqual(22, m3.B);
        Assert.AreEqual(43, m3.C);
        Assert.AreEqual(50, m3.D);
        Assert.AreEqual(m1.A * m2.A + m1.B * m2.C, m3.A);
        Assert.AreEqual(m1.A * m2.B + m1.B * m2.D, m3.B);
        Assert.AreEqual(m1.C * m2.A + m1.D * m2.C, m3.C);
        Assert.AreEqual(m1.C * m2.B + m1.D * m2.D, m3.D);
    }
}
