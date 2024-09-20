namespace Week3.Day_40_18_09_2024;

public class Bai169 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray(); 
        int largestEven = FindLargestEvenSmallerThanOdd(intArray);
        if (largestEven == -1)
        {
            Console.WriteLine("Khong co so chan nho hon tat ca cac so le.");
        }
        else
        {
            Console.WriteLine("So chan lon nhat nho hon moi gia tri le la: " + largestEven);
        }
    }

    private int FindLargestEvenSmallerThanOdd(int[] array)
    {
        int largestOdd = int.MinValue;
        foreach (int num in array)
        {
            if (num % 2 != 0 && num > largestOdd)
            {
                largestOdd = num;
            }
        }

        int largestEven = -1;
        foreach (int num in array)
        {
            if (num % 2 == 0 && num < largestOdd && num > largestEven)
            {
                largestEven = num;
            }
        }
        return largestEven;
    }
}
