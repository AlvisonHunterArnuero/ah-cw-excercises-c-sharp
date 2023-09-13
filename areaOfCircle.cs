using System;

public static class Kata
{
    public static double CalculateAreaOfCircle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be a positive number.");
        }

        double area = Math.PI * Math.Pow(radius, 2);
        return Math.Round(area, 3);
    }
}