using System;

class Program
{
    static double CalculateFutureValue(double amount, double rate, int years)
    {
        if (years == 0)
        {
            return amount;
        }

        return CalculateFutureValue(
            amount * (1 + rate),
            rate,
            years - 1
        );
    }

    static void Main()
    {
        double initialAmount = 10000;
        double growthRate = 0.10;
        int years = 5;

        double futureValue =
            CalculateFutureValue(
                initialAmount,
                growthRate,
                years
            );

        Console.WriteLine("Financial Forecasting using Recursion");
        Console.WriteLine("--------------------------------");

        Console.WriteLine(
            "Initial Amount: " + initialAmount
        );

        Console.WriteLine(
            "Growth Rate: " + (growthRate * 100) + "%"
        );

        Console.WriteLine(
            "Years: " + years
        );

        Console.WriteLine(
            "Future Value: " + futureValue
        );
    }
}