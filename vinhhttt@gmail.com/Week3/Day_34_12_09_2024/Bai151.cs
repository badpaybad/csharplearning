namespace Week3.Day_34_12_09_2024;

public class Bai151 : Homework
{
    public override void Run()
    {
        int[] intArrayForPrime = InputIntArray.GetInputIntArray();
        int maxPrime = FindMaxPrimeNumber(intArrayForPrime);
        if (maxPrime == 0)
        {
            Console.WriteLine("Mang khong co so nguyen to.");
        }
        else
        {
            Console.WriteLine("So nguyen to lon nhat trong mang la: " + maxPrime);
        }
    }

    private static int FindMaxPrimeNumber(int[] array)
    {
        int maxPrime = 0;
        foreach (int num in array)
        {
            if (IsPrime(num) && num > maxPrime)
            {
                maxPrime = num;
            }
        }

        return maxPrime;
    }

    private static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}