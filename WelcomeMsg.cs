using System;
using System.Collections.Generic;
public static class Kata
{
    public static string Greet(string language)
    {
        List<(string, string)> greetings = new List<(string, string)>
        {
            ("english", "Welcome"),
            ("czech", "Vitejte"),
            ("danish", "Velkomst"),
            ("dutch", "Welkom"),
            ("estonian", "Tere tulemast"),
            ("finnish", "Tervetuloa"),
            ("flemish", "Welgekomen"),
            ("french", "Bienvenue"),
            ("german", "Willkommen"),
            ("irish", "Failte"),
            ("italian", "Benvenuto"),
            ("latvian", "Gaidits"),
            ("lithuanian", "Laukiamas"),
            ("polish", "Witamy"),
            ("spanish", "Bienvenido"),
            ("swedish", "Valkommen"),
            ("welsh", "Croeso")
        };

        foreach (var tuple in greetings)
        {
            if (tuple.Item1 == language)
            {
                return tuple.Item2;
            }
        }

        return "Welcome";


    }
}