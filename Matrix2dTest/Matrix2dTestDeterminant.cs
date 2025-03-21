using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestDeterminant
{
    [TestMethod]
    public void Test_Det()
    {
        var m = new Matrix2d(1, 2, 3, 4);
        Assert.AreEqual(-2, m.Det());
    }
    [TestMethod]
    public void Test_Determinant()
    {
        var m = new Matrix2d(1, 2, 3, 4);
        Assert.AreEqual(-2, Matrix2d.Determinant(m));
    }
}
