namespace Methods
{
    using System;

    public class Methods
    {
        internal static double CalculateTriangleArea(double aSide, double bSide, double cSide)
        {
            bool areSidesPositive = aSide > 0 || bSide > 0 || cSide > 0;
            bool canBeFormTriangle = aSide + bSide > cSide && aSide + cSide > bSide && bSide + cSide > aSide;

            if (!areSidesPositive)
            {
                throw new ArgumentOutOfRangeException("All sides of the triangle must be >= 0");
            }

            if (!canBeFormTriangle)
            {
                throw new ArgumentOutOfRangeException("No side can be longer than the sum of the other two sides");
            }

            double halfPerimeter = (aSide + bSide + cSide) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - aSide) * (halfPerimeter - bSide) * (halfPerimeter - cSide));
            return area;
        }

        internal static string NumberToDigitName(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return number + "is not a digit!";
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintNumberAsPercentage(double number)
        {
            {
                Console.WriteLine("{0:p0}", number);
            }
        }

        internal static void PrintNumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        internal static double CalculateDistance(
            double firstPointX,
            double firstPointY,
            double secondPointX,
            double secondPointY)
        {
            double distance = Math.Sqrt(((secondPointX - firstPointX) * (secondPointX - firstPointX))
                        + ((secondPointY - firstPointY) * (secondPointY - firstPointY)));
            return distance;
        }

        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointY - secondPointY) < AcceptableDifference;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointX - secondPointX) < AcceptableDifference;
        }
    }
}
