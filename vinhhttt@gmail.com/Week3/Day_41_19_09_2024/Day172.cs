namespace Week3.Day_41_18_09_2024

public class Bai172 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int lcm = FindLCMArray(intArray);
        Console.WriteLine("Boi chung nho nhat cua cac phan tu trong mang la: " + lcm);
    }

    private int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    private int FindLCMArray(int[] array)
    {
        int lcm = array[0];
        foreach (int num in array)
        {
            lcm = FindLCM(lcm, num);
        }
        return lcm;
    }

    private int FindGCD(int a, int b)
    {
        return b == 0 ? a : FindGCD(b, a % b);
    }
}