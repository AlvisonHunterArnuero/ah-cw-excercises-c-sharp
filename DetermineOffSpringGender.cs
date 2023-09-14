public static string ChromosomeCheck(string sperm)
{
    return sperm.Contains("XX") ? "Congratulations! You're going to have a daughter." : "Congratulations! You're going to have a son.";
}