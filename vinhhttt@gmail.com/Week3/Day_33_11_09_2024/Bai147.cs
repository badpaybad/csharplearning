namespace Week3.Day_33_11_09_2024;

public class Bai147 : Homework
{
    public override void Run()
    {
        float[] floatArrayForPositive = InputFloatArray.GetInputFloatArray();
        float lastPositive = FindLastPositiveNumber(floatArrayForPositive);
        if (lastPositive == -1)
        {
            Console.WriteLine("Mang khong co gia tri duong.");
        }
        else
        {
            Console.WriteLine("So duong cuoi cung trong mang la: " + lastPositive);
        }
    }

    private static float FindLastPositiveNumber(float[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                return array[i];
            }
        }

        return -1;
    }
}