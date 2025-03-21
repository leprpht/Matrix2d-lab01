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
    }
    [TestMethod]
    public void Test_Equals_False()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = new Matrix2d(1, 2, 3, 5);
        Assert.IsFalse(m1.Equals(m2));
    }
    [TestMethod]
    public void Test_Equals_Null()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        Matrix2d m2 = null;
        Assert.IsFalse(m1.Equals(m2));
    }
}
