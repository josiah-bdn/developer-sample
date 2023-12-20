using System;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            int result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        public static string FormatSeparators(params string[] items)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                if (i == items.Length -1)
                {
                    sb.Append($" {items[i]}");
                    break;
                }

                if (i == items.Length -2)
                {
                    sb.Append($"{items[i]} and");
                }

                else
                {
                    sb.Append($"{items[i]}, ");
                }
            }

            return sb.ToString();
        }
    }
}