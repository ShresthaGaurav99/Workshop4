using System;

public class ParameterDemo
{
    // 1. Increase using ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 2. GetFullName using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Gaurav Shrestha";   // assign your full name
    }

    // 3. SumAll using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
