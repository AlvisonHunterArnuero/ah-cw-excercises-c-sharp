using System;
using System.Linq;
public static bool TwoArePositive(int a, int b, int c)
{
    int[] args = { a, b, c };
    int count = 0;
    for (int n = 0; n < args.Length; n++)
    {
        if (args[n] > 0)
        {
            count++;
        }
    }


    return count > 1 ? true : false;
}