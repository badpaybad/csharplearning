namespace Week3.Day_39_17_09_2024;

public class Bai165 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int firstOddDigitNumber = FindFirstOddDigitNumber(intArray);
        if (firstOddDigitNumber == 0)
        {
            Console.WriteLine("Khong co so nao co chu so dau tien le.");
        }
        else
        {
            Console.WriteLine("So dau tien co chu so dau tien le la: " + firstOddDigitNumber);
        }
    }

    private int FindFirstOddDigitNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (IsFirstDigitOdd(num))
            {
                return num;
            }
        }
        return 0; 
    }

    private bool IsFirstDigitOdd(int num)
    {
        int firstDigit = Math.Abs(num);
        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }
        return firstDigit % 2 != 0;
    }
}
