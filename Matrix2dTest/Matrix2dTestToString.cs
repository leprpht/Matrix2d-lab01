using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestToString
{
    [TestMethod]
    public void Test_ToString()
    {
        var m = new Matrix2d(1, 2, 3, 4);
        Assert.AreEqual("[1, 2], [3, 4]", m.ToString());
    }
}