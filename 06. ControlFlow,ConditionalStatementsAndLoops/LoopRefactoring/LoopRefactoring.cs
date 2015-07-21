namespace LoopRefactoring
{
    using System;

    public class LoopRefactoring
    {
        public static void Main()
        {
        }

        public static void FoundValue(int[] numbers, int expectValue)
        {
            bool isFound = false;

            for (int index = 0; index < numbers.Length; index++)
            {
                int currentValue = numbers[index];
                if (currentValue == expectValue)
                {
                    isFound = true;
                }

                Console.WriteLine(currentValue);
            }

            if (isFound)
            {
                Console.WriteLine("Value found!");
            }
        }
    }
}
