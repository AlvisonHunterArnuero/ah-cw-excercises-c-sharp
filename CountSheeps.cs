public static int CountSheeps(bool[] sheeps)
{
    int count = 0;
    foreach (bool value in sheeps)
    {
        if (value) count++;
    }
    return count;
}