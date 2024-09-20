namespace Week3.Day_30_08_09_2024;

public class Bai137 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray();
        int minIndex = FindMinValuePosition(doubleArray);
        Console.WriteLine("Vi tri co gia tri nho nhat trong mang la: " + minIndex);
    }
    
    private static int FindMinValuePosition(double[] array)
    {
        if (array.Length == 0) return -1;

        int minIndex = 0;
        double minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        return minIndex;
    }
}