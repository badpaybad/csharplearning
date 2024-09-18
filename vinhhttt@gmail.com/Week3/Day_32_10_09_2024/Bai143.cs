namespace Week3.Day_32_10_09_2024;

public class Bai143 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int firstEven = FindFirstEvenNumber(intArray);
        if (firstEven == -1)
        {
            Console.WriteLine("Mang khong co so chan.");
        }
        else
        {
            Console.WriteLine("So chan dau tien trong mang la: " + firstEven);
        }
    }


    private static int FindFirstEvenNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                return num;
            }
        }

        return -1;
    }
}