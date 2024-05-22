using System;

public class BengalSparks
{
    public static int CalculateTotalBurningHours(int s1, int b1)
    {
        int totalHours = 0;
        int currentSparks = s1;

        while (currentSparks > 0)
        {
            totalHours += currentSparks * 2;

            int newSparks = (currentSparks / b1) * 2;

            currentSparks = (currentSparks % b1) + newSparks;
        }

        return totalHours;
    }

    public static void Main()
    {
        int s1 = 5;
        int b1 = 3;

        int totalBurningHours = CalculateTotalBurningHours(s1, b1);

        Console.WriteLine("Total burning hours: " + totalBurningHours);
    }
}
