using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EarthBattle
{
    public static string GoodVsEvil(string good, string evil)
    {
        Dictionary<string, string> BattleResults = new Dictionary<string, string> {
            { "good", "Battle Result: Good triumphs over Evil" },
            { "bad", "Battle Result: Evil eradicates all trace of Good" },
            { "tie", "Battle Result: No victor on this battle field" }
    };


        string[] arrGoodNums = good.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] arrEvilNums = evil.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        var goodTotal = arrGoodNums.Select(hob => (long)Convert.ToDouble(hob)).Sum();
        var evilTotal = arrEvilNums.Select(orc => (long)Convert.ToDouble(orc)).Sum();

        if (goodTotal == evilTotal)
        {
            return BattleResults["tie"];
        }
        else if (goodTotal > evilTotal)
        {
            return BattleResults["good"];
        }
        else
        {
            return BattleResults["bad"];
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
        Console.WriteLine(GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
        Console.WriteLine(GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
    }
}