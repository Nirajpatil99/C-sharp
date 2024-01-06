using System;

class TempSwitchCase
{
    static void displayResult(int iTemperature)
    {
        int t = iTemperature;

        switch (iTemperature)
        {
            case t:
                if (t < 10)
                    Console.WriteLine("Freezing weather");
                break;

            case t:
                if (t >= 10 && t <= 20)
                    Console.WriteLine("Very cold weather");
                break;

            case t:
                if (t >= 21 && t <= 30)
                    Console.WriteLine("Normal Temperature");
                break;

            default:
                Console.WriteLine("It is very Hot");
                break;
        }
    }

    static void Main()
    {
        int iTemp = 0;
        Console.WriteLine("Enter the Temperature");
        iTemp = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Temperature: " + iTemp);
        displayResult(iTemp);
    }
}