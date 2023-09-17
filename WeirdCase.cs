using System;
using System.Collections.Generic;

public class ChangeStringCaseToWeird
{
    public static string ToWeirdCase(string phrase)
    {
        string[] words = phrase.Split(" ");
        int TopCounter = 0;
        int innerCounter = 0;
        var tempWordList = new List<string>();
        string innerTempStr = "";

        foreach (var word in words)
        {
            if (word == " ")
            {
                innerTempStr += " ";
            }
            foreach (var w in word)
            {
                if (innerCounter % 2 == 0)
                {
                    innerTempStr += w.ToString().ToUpper();
                }
                else
                {
                    innerTempStr += w.ToString().ToLower();
                }
                innerCounter++;
            }
            innerTempStr += " ";
            tempWordList.Add(innerTempStr);
            TopCounter++;
            innerCounter = 0;
        }
        var weirdCasedStr = String.Join(", ", innerTempStr);
        weirdCasedStr = weirdCasedStr.Substring(0, weirdCasedStr.Length - 1);
        return weirdCasedStr;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine(ToWeirdCase("String"));
        Console.WriteLine(ToWeirdCase("Weird string case"));
        Console.WriteLine(ToWeirdCase("This"));
        Console.WriteLine(ToWeirdCase("BOY"));
        Console.WriteLine(ToWeirdCase("This is a test"));
        Console.WriteLine(ToWeirdCase("Alvison Hunter"));
    }
}
