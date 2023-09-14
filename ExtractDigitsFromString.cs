public static int FilterString(string testStr)
{
    string digits = new string(testStr.Where(char.IsDigit).ToArray());

    if (int.TryParse(digits, out int result))
    {
        return result;
    }
    else
    {
        throw new ArgumentException("Input string does not contain valid digits.");
    }
}