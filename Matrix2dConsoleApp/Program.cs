using Matrix2dLib;
namespace Matrix2dConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            var m2 = Matrix2d.Transpose(m1);
            Console.WriteLine(m2.ToString());
        }
    }
}
