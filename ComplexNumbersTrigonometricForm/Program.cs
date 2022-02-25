using System;

namespace ComplexNumbersTrigonometricForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg két számot!\n");

            Console.Write("a: ");
            var a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nz = {a} + {(b == 1 ? string.Empty : b)}i\n");

            var result = TrigonometricForm(a, b);

            Console.WriteLine($"\ntrigonometrikus alak: {result}");

            Console.ReadKey();
        }

        static string TrigonometricForm(double a, double b)
        {
            var r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"r: SQRT({Math.Round(Math.Pow(a, 2), 2)} + {Math.Round(Math.Pow(b, 2), 2)}) = {Math.Round(r, 2)}");

            var rad = Math.Atan2(b, a);
            var alpha = rad * (180/Math.PI);
            if (alpha < 0) alpha = alpha + 180;
            Console.WriteLine("alfa: " + Math.Round(alpha, 1) + "°");

            return $"{Math.Round(r, 2)} * (cos({Math.Round(alpha, 1)}°) + i * sin({Math.Round(alpha, 1)}°))";
        }
    }
}
