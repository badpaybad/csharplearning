namespace ChungnbAbstractClass.Support;

class SupportMath
{
    public static bool IsPrime(int number)
    {
        int half     = (int)(number / 2);
        bool isPrime = true;
        for (int i = 2; i <= half; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }

    public static bool IsPerfectNumber(int number)
    {
        int[] wishes    = GetNumberWishes(number);
        int countWishes = wishes.Length;
        int sum         = 0;

        for (int i = 0; i < countWishes; i++)
        {
            sum += wishes[i];
        }

        return number == sum;
    }

    public static int[] GetNumberWishes(int number)
    {
        int half         = number / 2;
        List<int> wishes = new List<int>();

        for (int i = 1; i <= half; i++)
        {
            if (number % i == 0)
            {
                wishes.Add(i);
            }
        }
        
        return wishes.ToArray();
    }
}
