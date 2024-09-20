namespace Week3.Day_36_14_09_2024;

public class Bai157 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray(); 
        (double a, double b) = FindIntervalContainingAllValues(doubleArray);
        Console.WriteLine("Đoan [a, b] chua tat ca cac gia tri trong mang: [" + a + ", " + b + "]");
    }

    private (double, double) FindIntervalContainingAllValues(double[] array)
    {
        double min = array[0];
        double max = array[0];

        foreach (double num in array)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return (min, max);
    }
}
