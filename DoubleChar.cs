public class Kata
{
    public static string DoubleChar(string s)
    {
        char[] splittedWord = s.ToCharArray();
        char[] duplicatedArray = new char[splittedWord.Length * 2];
        for (int i = 0; i < splittedWord.Length; i++)
        {
            duplicatedArray[i * 2] = splittedWord[i];
            duplicatedArray[i * 2 + 1] = splittedWord[i];
        }
        return string.Join("", duplicatedArray);
    }
}