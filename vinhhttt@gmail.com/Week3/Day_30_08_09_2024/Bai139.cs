namespace Week3.Day_30_08_09_2024;

public class Bai139 : Homework
{
    public override void Run()
    {
        int[] intArrayForPerfect = InputIntArray.GetInputIntArray();
        int lastPerfectIndex = FindLastPerfectNumberPosition(intArrayForPerfect);
        if (lastPerfectIndex == -1)
        {
            Console.WriteLine("Mang khong co so hoan thien.");
        }
        else
        {
            Console.WriteLine("Vi tri cua so hoan thien cuoi cung trong mang la: " + lastPerfectIndex);
        }
    }

    private static int FindLastPerfectNumberPosition(int[] array)
    {
        int lastIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (IsPerfectNumber(array[i]))
            {
                lastIndex = i;
            }
        }

        return lastIndex;
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