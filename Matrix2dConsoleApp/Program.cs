using Matrix2dLib;
namespace Matrix2dConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Matrix2d(1, 2, 3, 4);
            Console.WriteLine($"=== Matrix 1, 2, 3, 4 ===\n{m1.ToString()}\n");
            var m2 = new Matrix2d();
            Console.WriteLine($"=== Matrix with empty constructor ===\n{m2.ToString()}\n");
            Console.WriteLine($"=== Identity matrix ===\n{Matrix2d.Id.ToString()}\n");
            Console.WriteLine($"=== Zero matrix ===\n{Matrix2d.Zero.ToString()}\n");
            var m3 = new Matrix2d(1, 2, 3, 4);
            Console.WriteLine($"=== Equals Method ===\n{m1.Equals(m3)}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} == m3: {m3.ToString()} ===\n{m1 == m3}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} != m2: {m2.ToString()} ===\n{m1 != m2}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} == m2: {m2.ToString()} ===\n{m1 == m2}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} != m3: {m3.ToString()} ===\n{m1 != m3}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} + m2: {m2.ToString()} ===\n{m1 + m2}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} - m2: {m2.ToString()} ===\n{m1 - m2}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} * m2: {m2.ToString()} ===\n{m1 * m2}\n");
            Console.WriteLine($"=== Matrix m1: {m1.ToString()} * m3: {m3.ToString()} ===\n{m1 * m3}\n");
            Console.WriteLine($"=== -m1 ===\n{-m1}\n");
            int[,] int1 = (int[,])m1;
            Console.WriteLine($"=== Conversion from Matrix2d to int[,] ===\n[{int1[0, 0]}, {int1[0, 1]}], [{int1[1, 0]}, {int1[1, 1]}]\n");
            Matrix2d m4 = int1;
            Console.WriteLine($"=== Conversion from int[,] to Matrix2d ===\n{m4.ToString()}\n");
            var m5 = Matrix2d.Parse("[5, 6], [7, 8]");
            Console.WriteLine($"=== Parse Method ===\n{m5.ToString()}\n");
            var m6 = Matrix2d.Transpose(m5);
            Console.WriteLine($"=== Transpose Method ===\n{m6.ToString()}\n");
            Console.WriteLine($"=== Determinant Method ===\nm6.Det: {m6.Det()}\nMatrix2d.Determinant(m6): {Matrix2d.Determinant(m6)}\n");
        }
    }
}
