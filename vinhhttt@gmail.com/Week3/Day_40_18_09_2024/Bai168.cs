namespace Week3.Day_40_18_09_2024;

public class Bai168 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray(); 
        int maxPowerOfFive = FindMaxPowerOfFive(intArray);
        if (maxPowerOfFive == 0)
        {
            Console.WriteLine("Khong co so nao co dang 5^k.");
        }
        else
        {
            Console.WriteLine("So lon nhat co dang 5^k la: " + maxPowerOfFive);
        }
    }

    private int FindMaxPowerOfFive(int[] array)
    {
        int max = 0;
        foreach (int num in array)
        {
            if (IsPowerOfFive(num) && num > max)
            {
                max = num;
            }
        }
        return max;
    }

    private bool IsPowerOfFive(int num)
    {
        if (num <= 0) return false;
        while (num % 5 == 0)
        {
            num /= 5;
        }
        return num == 1;
    }
}
