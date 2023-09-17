using System;
using System.Collections.Generic;

public class OddOccurrences
{
    public static int find_it(int[] numbers)
    {
        Dictionary<int, int> countDictionary = new Dictionary<int, int>();
        foreach (int num in numbers)
        {
            if (countDictionary.ContainsKey(num))
            {
                countDictionary[num]++;
            }
            else
            {
                countDictionary[num] = 1;
            }
        }

        foreach (var oddCountInt in countDictionary)
        {
            if (oddCountInt.Value % 2 != 0)
            {
                return oddCountInt.Key;
            }
        }
        return 0;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(find_it(new[] { 7 }));
        Console.WriteLine(find_it(new[] { 0 }));
        Console.WriteLine(find_it(new[] { 1, 1, 2 }));
        Console.WriteLine(find_it(new[] { 0, 1, 0, 1, 0 }));
        Console.WriteLine(find_it(new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }));
    }
}