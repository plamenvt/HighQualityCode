namespace SumOfDifferences
{
    using System;

    internal class SumOfDifferences
    {
        internal static long FindTotalDifference(long[] numbers)
        {
            long totalDifference = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                bool isEven = false;
                long differenceAbsolute = 0;

                if (numbers[i] > numbers[i - 1])
                {
                    differenceAbsolute = numbers[i] - numbers[i - 1];
                }
                else
                {
                    differenceAbsolute = numbers[i - 1] - numbers[i];
                }

                if (differenceAbsolute % 2 == 0)
                {
                    isEven = true;
                }

                if (isEven)
                {
                    i += 1;
                }

                if (differenceAbsolute % 2 != 0)
                {
                    totalDifference += differenceAbsolute;
                }
            }

            return totalDifference;
        }

        private static void Main()
        {
            string[] sequence = Console.ReadLine().Split(' ');
            long[] numbers = new long[sequence.Length];

            for (int j = 0; j < sequence.Length; j++)
            {
                numbers[j] = long.Parse(sequence[j]);
            }

            Console.WriteLine(FindTotalDifference(numbers));
        }
    }
}
