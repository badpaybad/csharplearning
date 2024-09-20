namespace Week3.Day_36_14_09_2024;

public class Bai156 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray();
        Console.WriteLine("Nhap gia tri x:");
        double x = double.Parse(Console.ReadLine() ?? string.Empty);

        int closestPosition = FindClosestPositionToX(doubleArray, x);
        Console.WriteLine("Vi tri gia tri gan x nhat: " + closestPosition);
    }

    private int FindClosestPositionToX(double[] array, double x)
    {
        double minDistance = double.MaxValue;
        int closestPosition = -1;

        for (int i = 0; i < array.Length; i++)
        {
            double distance = Math.Abs(array[i] - x);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestPosition = i;
            }
        }
        return closestPosition;
    }
}
