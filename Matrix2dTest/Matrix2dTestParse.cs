using Matrix2dLib;
namespace Matrix2dTest;

[TestClass]
public class Matrix2dTestParse
{
    [TestMethod]
    public void Test_Parse()
    {
        var m = Matrix2d.Parse("[1, 2], [3, 4]");
        Assert.AreEqual(1, m.A);
        Assert.AreEqual(2, m.B);
        Assert.AreEqual(3, m.C);
        Assert.AreEqual(4, m.D);
    }
    [TestMethod]
    public void Test_Parse_Invalid()
    {
        Assert.ThrowsException<FormatException>(() => Matrix2d.Parse("[1, 2], [3]"));
    }
}
