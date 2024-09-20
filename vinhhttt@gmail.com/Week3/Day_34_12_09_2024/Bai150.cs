namespace Week3.Day_34_12_09_2024;

public class Bai150 : Homework
{
    public override void Run()
    {
        float[] floatArray = InputFloatArray.GetInputFloatArray();
        float maxNegative = FindMaxNegativeNumber(floatArray);
        if (maxNegative == 0)
        {
            Console.WriteLine("Mang khong co gia tri am.");
        }
        else
        {
            Console.WriteLine("Gia tri am lon nhat trong mang la: " + maxNegative);
        }
    }

    private static float FindMaxNegativeNumber(float[] array)
    {
        float maxNegative = 0;
        foreach (float num in array)
        {
            if (num < 0 && (maxNegative == 0 || num > maxNegative))
            {
                maxNegative = num;
            }
        }

        return maxNegative;
    }
}