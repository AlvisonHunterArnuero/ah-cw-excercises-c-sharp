using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        var filteredArray = names.Where(s => s.Length <= 4).ToArray();
        return filteredArray;
    }
}