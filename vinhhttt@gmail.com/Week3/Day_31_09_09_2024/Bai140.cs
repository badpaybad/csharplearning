namespace Week3.Day_31_09_09_2024;

public class Bai140 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray();
        double smallestPositive = FindSmallestPositiveValue(doubleArray);
        if (smallestPositive == -1)
        {
            Console.WriteLine("Mang khong co gia tri duong.");
        }
        else
        {
            Console.WriteLine("Gia tri duong nho nhat trong mang la: " + smallestPositive);
        }
    }

    private static double FindSmallestPositiveValue(double[] array)
    {
        double smallestPositive = -1;

        foreach (double num in array)
        {
            if (num > 0 && (smallestPositive == -1 || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }

        return smallestPositive;
    }
}