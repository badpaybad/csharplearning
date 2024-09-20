namespace Week3.Day_33_11_09_2024;

public class Bai146 : Homework
{
    public override void Run()
    {
        float[] floatArray = InputFloatArray.GetInputFloatArray();
        float firstNegative = FindFirstNegativeNumber(floatArray);
        if (firstNegative == 1)
        {
            Console.WriteLine("Mang khong co gia tri am.");
        }
        else
        {
            Console.WriteLine("Gia tri am dau tien trong mang la: " + firstNegative);
        }
    }

    private static float FindFirstNegativeNumber(float[] array)
    {
        foreach (float num in array)
        {
            if (num < 0)
            {
                return num;
            }
        }

        return 1;
    }
}