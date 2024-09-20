namespace Week3.Day_40_18_09_2024;

public class Bai167 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int maxOddDigitsNumber = FindMaxOddDigitsNumber(intArray);
        if (maxOddDigitsNumber == 0)
        {
            Console.WriteLine("Khong co so nao toan chu so le.");
        }
        else
        {
            Console.WriteLine("So lon nhat toan chu so le la: " + maxOddDigitsNumber);
        }
    }

    private int FindMaxOddDigitsNumber(int[] array)
    {
        int max = 0;
        foreach (int num in array)
        {
            if (IsAllOddDigits(num) && num > max)
            {
                max = num;
            }
        }
        return max;
    }

    private bool IsAllOddDigits(int num)
    {
        int n = Math.Abs(num);
        while (n > 0)
        {
            if (n % 10 % 2 == 0) return false;
            n /= 10;
        }
        return true;
    }
}
