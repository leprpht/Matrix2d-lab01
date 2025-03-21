using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestStatics
{
    [TestMethod]
    public void Test_Static_Id()
    {
        Assert.AreEqual(1, Matrix2d.Id.A);
        Assert.AreEqual(0, Matrix2d.Id.B);
        Assert.AreEqual(0, Matrix2d.Id.C);
        Assert.AreEqual(1, Matrix2d.Id.D);
    }
    [TestMethod]
    public void Test_Static_Zero()
    {
        Assert.AreEqual(0, Matrix2d.Zero.A);
        Assert.AreEqual(0, Matrix2d.Zero.B);
        Assert.AreEqual(0, Matrix2d.Zero.C);
        Assert.AreEqual(0, Matrix2d.Zero.D);
    }
}
