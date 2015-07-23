namespace Methods
{
    using System;

    internal class MainMethodForTesting
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(17, 13, 15));

            Console.WriteLine(Methods.NumberToDigitName(7));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintNumberWithPrecision(1.7);
            Methods.PrintNumberAsPercentage(3.74);
            Methods.PrintNumberAlignedRight(6.31);

            bool horizontal = Methods.IsLineHorizontal(-1, 2.5);
            bool vertical = Methods.IsLineVertical(3, 3);

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student ivan = new Student("Ivan", "Petrov", new DateTime(1988, 3, 17), "Smoker");
            Student gosho = new Student("Gosho", "Stoyanov", new DateTime(1966, 11, 3), "Have 3 children");

            Console.WriteLine("{0} older than {1} -> {2}", ivan.FirstName, gosho.FirstName, ivan.IsOlderThan(gosho));
        }
    }
}
