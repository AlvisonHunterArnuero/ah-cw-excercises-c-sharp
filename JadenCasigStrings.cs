using System;
using System.Globalization;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        phrase = textInfo.ToTitleCase(phrase);
        return phrase;
    }
}