namespace Week3.Day_33_11_09_2024;

public class Bai148 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int lastPrime = FindLastPrimeNumber(intArray);
        if (lastPrime == -1)
        {
            Console.WriteLine("Mang khong co so nguyen to.");
        }
        else
        {
            Console.WriteLine("So nguyen to cuoi cung trong mang la: " + lastPrime);
        }
    }

    private static int FindLastPrimeNumber(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (IsPrime(array[i]))
            {
                return array[i];
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