namespace Week3.Day_30_08_09_2024;

public class Bai138 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int firstEvenIndex = FindFirstEvenPosition(intArray);
        if (firstEvenIndex == -1)
        {
            Console.WriteLine("Mang khong co gia tri chan.");
        }
        else
        {
            Console.WriteLine("Vi tri cua gia tri chan dau tien trong mang la: " + firstEvenIndex);
        }
    }
    
    private static int FindFirstEvenPosition(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                return i;
            }
        }
        return -1;
    }
}