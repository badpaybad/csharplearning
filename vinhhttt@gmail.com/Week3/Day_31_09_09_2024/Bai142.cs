namespace Week3.Day_31_09_09_2024;

public class Bai142 : Homework
{
    public override void Run()
    {
        double[] doubleArrayForMin = InputDoubleArray.GetDoubleArray();
        double minValue = FindMinValue(doubleArrayForMin);
        Console.WriteLine("Gia tri nho nhat trong mang la: " + minValue);
    }

    private static double FindMinValue(double[] array)
    {
        if (array.Length == 0) return double.MaxValue;

        double minValue = array[0];

        foreach (double num in array)
        {
            if (num < minValue)
            {
                minValue = num;
            }
        }

        return minValue;
    }
}