using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ConsonantValue
{
    public static int Solve(string str)
    {
        Dictionary<char, int> Letters = new Dictionary<char, int> { { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'f', 6 }, { 'g', 7 }, { 'h', 8 }, { 'j', 10 }, { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'p', 16 }, { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 }, { 'z', 26 } };

        string vowels = "[aeiouAEIOU]";
        string replacement = "-";

        Regex rep = new Regex(vowels);

        string updatedString = rep.Replace(str, replacement);
        string[] resultingSubStr = updatedString.Split("-", StringSplitOptions.RemoveEmptyEntries);
        var lstElemTotals = new List<int>();

        foreach (var upd in resultingSubStr)
        {
            int innerSum = 0;
            foreach (var s in upd)
            {
                if (Letters.ContainsKey(s)) // Not really needed but looks tuanis
                {
                    innerSum += Letters[s];
                }
            } // end inner foreach
            lstElemTotals.Add(innerSum);
        } // end updatedString


        return lstElemTotals.Max();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Solve("zodiacs"));
        Console.WriteLine(Solve("chruschtschov"));
        Console.WriteLine(Solve("khrushchev"));
        Console.WriteLine(Solve("strength"));
        Console.WriteLine(Solve("catchphrase"));
        Console.WriteLine(Solve("twelfthstreet"));
        Console.WriteLine(Solve("mischtschenkoana"));
        Console.WriteLine(Solve("hqeavgbkyfgrfyrrudsbxfd"));
    }
}