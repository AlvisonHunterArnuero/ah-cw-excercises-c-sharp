using System;
using System.Collections.Generic;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        for (int i = 0; i < str.Length; i++)
        {
            if (vowels.Contains(str[i]))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}
