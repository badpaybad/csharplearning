namespace Week3.Day_36_14_09_2024;

public class Bai155 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray();
        Console.WriteLine("Nhap gia tri x:");
        double x = double.Parse(Console.ReadLine() ?? "0");

        double farthestValue = FindFarthestFromX(doubleArray, x);
        Console.WriteLine("Gia tri trong mang xa gia tri x nhất: " + farthestValue);
    }

    private double FindFarthestFromX(double[] array, double x)
    {
        double maxDistance = 0;
        double farthestValue = array[0];

        foreach (double num in array)
        {
            double distance = Math.Abs(num - x);
            if (distance > maxDistance)
            {
                maxDistance = distance;
                farthestValue = num;
            }
        }
        return farthestValue;
    }
}
