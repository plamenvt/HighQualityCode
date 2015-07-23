namespace MathProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class MathProblem
    {
        private static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            List<int> result = new List<int>();
            long sum = 0;
            long number = 0;
            long finalSum = 0;
            List<int> str = new List<int>();
            StringBuilder finalWord = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (currentWord[j] == 'a')
                    {
                        result.Add(0);
                    }
                    else if (currentWord[j] == 'b')
                    {
                        result.Add(1);
                    }
                    else if (currentWord[j] == 'c')
                    {
                        result.Add(2);
                    }
                    else if (currentWord[j] == 'd')
                    {
                        result.Add(3);
                    }
                    else if (currentWord[j] == 'e')
                    {
                        result.Add(4);
                    }
                    else if (currentWord[j] == 'f')
                    {
                        result.Add(5);
                    }
                    else if (currentWord[j] == 'g')
                    {
                        result.Add(6);
                    }
                    else if (currentWord[j] == 'h')
                    {
                        result.Add(7);
                    }
                    else if (currentWord[j] == 'i')
                    {
                        result.Add(8);
                    }
                    else if (currentWord[j] == 'j')
                    {
                        result.Add(9);
                    }
                    else if (currentWord[j] == 'k')
                    {
                        result.Add(10);
                    }
                    else if (currentWord[j] == 'l')
                    {
                        result.Add(11);
                    }
                    else if (currentWord[j] == 'm')
                    {
                        result.Add(12);
                    }
                    else if (currentWord[j] == 'n')
                    {
                        result.Add(13);
                    }
                    else if (currentWord[j] == 'o')
                    {
                        result.Add(14);
                    }
                    else if (currentWord[j] == 'p')
                    {
                        result.Add(15);
                    }
                    else if (currentWord[j] == 'q')
                    {
                        result.Add(16);
                    }
                    else if (currentWord[j] == 'r')
                    {
                        result.Add(17);
                    }
                    else if (currentWord[j] == 's')
                    {
                        result.Add(18);
                    }
                }

                for (int r = 0; r < result.Count; r++)
                {
                    number += result[r] * (long)Math.Pow(19, result.Count - r - 1);
                }

                result.Clear();
            }

            sum += number;
            finalSum = sum;
            while (sum > 0)
            {
                int a = (int)sum % 19;
                str.Add(a);

                sum /= 19;
            }

            for (int i = 0; i < str.Count; i++)
            {
                int digit = str[i];
                switch (digit)
                {
                    case 0: finalWord.Append("a");
                        break;
                    case 1: finalWord.Append("b");
                        break;
                    case 2: finalWord.Append("c");
                        break;
                    case 3: finalWord.Append("d");
                        break;
                    case 4: finalWord.Append("e");
                        break;
                    case 5: finalWord.Append("f");
                        break;
                    case 6: finalWord.Append("g");
                        break;
                    case 7: finalWord.Append("h");
                        break;
                    case 8: finalWord.Append("i");
                        break;
                    case 9: finalWord.Append("j"); 
                        break;
                    case 10: finalWord.Append("k");
                        break;
                    case 11: finalWord.Append("l");
                        break;
                    case 12: finalWord.Append("m");
                        break;
                    case 13: finalWord.Append("n");
                        break;
                    case 14: finalWord.Append("o");
                        break;
                    case 15: finalWord.Append("p");
                        break;
                    case 16: finalWord.Append("q");
                        break;
                    case 17: finalWord.Append("r");
                        break;
                    case 18: finalWord.Append("s"); 
                        break;
                }
            }

            for (int m = finalWord.Length - 1; m >= 0; m--)
            {
                Console.Write(finalWord[m]);
            }

            Console.WriteLine(" = {0}", finalSum);
        }
    }
}
