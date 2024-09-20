namespace Week3.Day_41_18_09_2024
public class Bai171 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int gcd = FindGCDArray(intArray);
        Console.WriteLine("Uoc chung lon nhat cua cac phan tu trong mang la: " + gcd);
    }

    private int FindGCD(int a, int b)
    {
        return b == 0 ? a : FindGCD(b, a % b);
    }

    private int FindGCDArray(int[] array)
    {
        int gcd = array[0];
        foreach (int num in array)
        {
            gcd = FindGCD(gcd, num);
        }
        return gcd;
    }
}