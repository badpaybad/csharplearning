namespace Week3.Day_35_13_09_2024;

public class Bai152 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int minPerfect = FindSmallestPerfectNumber(intArray);
        if (minPerfect == 0)
        {
            Console.WriteLine("Mang khong co so hoan thien.");
        }
        else
        {
            Console.WriteLine("So hoan thien nho nhat trong mang la: " + minPerfect);
        }
    }

    private int FindSmallestPerfectNumber(int[] array)
    {
        int minPerfect = int.MaxValue;
        foreach (int num in array)
        {
            if (IsPerfectNumber(num) && num < minPerfect)
            {
                minPerfect = num;
            }
        }
        return minPerfect == int.MaxValue ? 0 : minPerfect;
    }

    private bool IsPerfectNumber(int num)
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
