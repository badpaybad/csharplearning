namespace Week3.Day_32_10_09_2024;

public class Bai145 : Homework
{
    public override void Run()
    {
        int[] intArrayForPerfect = InputIntArray.GetInputIntArray();
        int firstPerfect = FindFirstPerfectNumber(intArrayForPerfect);
        if (firstPerfect == -1)
        {
            Console.WriteLine("Mang khong co so hoan thien.");
        }
        else
        {
            Console.WriteLine("So hoan thien dau tien trong mang la: " + firstPerfect);
        }
    }
    private static int FindFirstPerfectNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (IsPerfectNumber(num))
            {
                return num;
            }
        }
        return -1; // Không có số hoàn thiện
    }

    private static bool IsPerfectNumber(int num)
    {
        if (num < 1) return false;

        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        return sum == num;
    }
}