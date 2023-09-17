using System;
using System.Text;

public class Diamond
{
    public static string print(int n)
    {
        string newLineChar = "\n";
        if (n >= 3 && n % 2 != 0)
        {
            StringBuilder starCombinedPattern = new StringBuilder();
            string[] diamondTopHalf = new string[(n - 1) / 2];
            int maxStarsHalf = (n - 1) / 2;

            for (int i = 0; i < maxStarsHalf; i++)
            {
                string patternPrefix = new string(' ', (maxStarsHalf - i));
                string patternChar = new string('*', i * 2 + 1);
                diamondTopHalf[i] = patternPrefix + patternChar + newLineChar;
            }

            starCombinedPattern.Append(string.Join("", diamondTopHalf));
            starCombinedPattern.Append(new string('*', n) + newLineChar);

            for (int i = diamondTopHalf.Length - 1; i >= 0; i--)
            {
                starCombinedPattern.Append(diamondTopHalf[i]);
            }

            return starCombinedPattern.ToString();
        }
        else
        {
            return null;
        }

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(print(0));
        Console.WriteLine(print(-2));
        Console.WriteLine(print(2));
        Console.WriteLine(print(1));
        Console.WriteLine(print(3));
        Console.WriteLine(print(5));
        Console.WriteLine(print(9));
    }
}


def distinct(seq):
    v = []
    for a in seq:
        if a not in v:
v.append(a)
    return v