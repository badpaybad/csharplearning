namespace Week3.Day_32_10_09_2024;

public class Bai144 : Homework
{
    public override void Run()
    {
        int[] intArrayForPrime = InputIntArray.GetInputIntArray();
        int firstPrime = FindFirstPrimeNumber(intArrayForPrime);
        if (firstPrime == -1)
        {
            Console.WriteLine("Mang khong co so nguyen to.");
        }
        else
        {
            Console.WriteLine("So nguyen to dau tien trong mang la: " + firstPrime);
        }
    }

    private static int FindFirstPrimeNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (IsPrime(num))
            {
                return num;
            }
        }

        return -1;
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