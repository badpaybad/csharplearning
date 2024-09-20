namespace Week3.Day_31_09_09_2024;

public class Bai141 : Homework
{
    public override void Run()
    {
        double[] doubleArrayForPosition = InputDoubleArray.GetDoubleArray();
        int smallestPositivePosition = FindSmallestPositiveValuePosition(doubleArrayForPosition);
        if (smallestPositivePosition == -1)
        {
            Console.WriteLine("Mang khong co gia tri duong.");
        }
        else
        {
            Console.WriteLine("Vi tri cua gia tri duong nho nhat trong mang la: " + smallestPositivePosition);
        }
    }

    private static int FindSmallestPositiveValuePosition(double[] array)
    {
        int position = -1;
        double smallestPositive = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && (smallestPositive == -1 || array[i] < smallestPositive))
            {
                smallestPositive = array[i];
                position = i;
            }
        }

        return position;
    }
}