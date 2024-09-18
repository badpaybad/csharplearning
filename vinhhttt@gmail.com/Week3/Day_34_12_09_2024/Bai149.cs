namespace Week3.Day_34_12_09_2024;

public class Bai149 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int lastPerfect = FindLastPerfectNumber(intArray);
        if (lastPerfect == -1)
        {
            Console.WriteLine("Mang khong co so hoan thien.");
        }
        else
        {
            Console.WriteLine("So hoan thien cuoi cung trong mang la: " + lastPerfect);
        }
    }

    private static int FindLastPerfectNumber(int[] array)
    {
        int lastPerfect = -1;
        foreach (int num in array)
        {
            if (IsPerfectNumber(num))
            {
                lastPerfect = num;
            }
        }

        return lastPerfect;
    }

    private static bool IsPerfectNumber(int num)
    {
        if (num < 1) return false;
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum == num;
    }
}