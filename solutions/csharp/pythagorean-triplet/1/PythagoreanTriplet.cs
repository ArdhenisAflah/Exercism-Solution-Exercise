using System.Collections.Generic;
public class PythagoreanSolver
{
 public struct Triple
{
    public int a, b, c;
    public int Sum => a + b + c;
    public Triple(int a, int b, int c) => (this.a, this.b, this.c) = (a, b, c);
}

public static class PythagoreanProvider
{
    /// <summary>
    /// Mengembalikan daftar 75 Tripel Pythagoras Primitif sebagai IEnumerable.
    /// </summary>
    public static IEnumerable<Triple> GetPrimitives() => new Triple[]
    {
        new(3, 4, 5),     new(5, 12, 13),   new(7, 24, 25),   new(8, 15, 17),   new(9, 40, 41),
        new(11, 60, 61),  new(12, 35, 37),  new(13, 84, 85),  new(15, 112, 113), new(16, 63, 65),
        new(17, 144, 145), new(19, 180, 181), new(20, 21, 29),  new(20, 99, 101), new(21, 220, 221),
        new(23, 264, 265), new(24, 143, 145), new(25, 312, 313), new(27, 364, 365), new(28, 45, 53),
        new(28, 195, 197), new(29, 420, 421), new(31, 480, 481), new(32, 255, 257), new(33, 56, 65),
        new(33, 544, 545), new(35, 612, 613), new(36, 77, 85),  new(36, 323, 325), new(37, 684, 685),
        new(39, 80, 89),  new(39, 760, 761), new(40, 399, 401), new(41, 840, 841), new(43, 924, 925),
        new(44, 117, 125), new(44, 483, 485), new(48, 55, 73),  new(48, 575, 577), new(51, 140, 149),
        new(52, 165, 173), new(52, 675, 677), new(56, 783, 785), new(57, 176, 185), new(60, 91, 109),
        new(60, 221, 229), new(60, 899, 901), new(65, 72, 97),  new(68, 285, 293), new(69, 260, 269),
        new(75, 308, 317), new(76, 357, 365), new(84, 187, 205), new(84, 437, 445), new(85, 132, 157),
        new(87, 416, 425), new(88, 105, 137), new(92, 525, 533), new(93, 476, 485), new(95, 168, 193),
        new(96, 247, 265), new(100, 621, 629), new(104, 153, 185), new(105, 208, 233), new(105, 608, 617),
        new(108, 725, 733), new(111, 680, 689), new(115, 252, 277), new(116, 837, 845), new(119, 120, 169),
        new(120, 209, 241), new(120, 391, 409), new(123, 836, 845), new(124, 957, 965), new(129, 920, 929)
    };
}

    public static IEnumerable<Triple> FindMatches(int targetN)
    {
        // Menggunakan LINQ untuk memfilter list berdasarkan logika sisa bagi (modulus)
        return PythagoreanProvider.GetPrimitives()
            .Where(t => targetN % t.Sum == 0)
            .Select(t => 
            {
                int k = targetN / t.Sum;
                return new Triple(t.a * k, t.b * k, t.c * k);
            });
    }
}
public static class PythagoreanTriplet
{

    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
      return PythagoreanSolver.FindMatches(sum)
            .Select(t => (t.a, t.b, t.c)).OrderBy(t => t.a);
    }
}