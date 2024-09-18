namespace Week3.Day_35_13_09_2024;

public class Bai153 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int minEven = FindSmallestEvenNumber(intArray);
        if (minEven == -1)
        {
            Console.WriteLine("Mang khong co so chan.");
        }
        else
        {
            Console.WriteLine("So chan nho nhat trong mang la: " + minEven);
        }
    }

    private int FindSmallestEvenNumber(int[] array)
    {
        int minEven = int.MaxValue;
        foreach (int num in array)
        {
            if (num % 2 == 0 && num < minEven)
            {
                minEven = num;
            }
        }
        return minEven == int.MaxValue ? -1 : minEven;
    }
}
