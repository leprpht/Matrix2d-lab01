using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestTranspose
{
    [TestMethod]
    public void Test_Transpose()
    {
        var m1 = new Matrix2d(1, 2, 3, 4);
        var m2 = Matrix2d.Transpose(m1);
        Assert.AreEqual(1, m2.A);
        Assert.AreEqual(3, m2.B);
        Assert.AreEqual(2, m2.C);
        Assert.AreEqual(4, m2.D);
    }
}
