namespace Week3.Day_38_16_09_2024;

public class Bai161 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray(); 
        Console.Write("Nhap gia tri x: ");
        int x = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Nhap gia tri y: ");
        int y = int.Parse(Console.ReadLine() ?? string.Empty);

        int firstValue = FindFirstValueInRange(intArray, x, y);
        if (firstValue == x)
        {
            Console.WriteLine("Khong co gia tri nao nam trong khoang (" + x + ", " + y + ").");
        }
        else
        {
            Console.WriteLine("Gia tri dau tien trong khoang (" + x + ", " + y + ") la: " + firstValue);
        }
    }

    private int FindFirstValueInRange(int[] array, int x, int y)
    {
        foreach (int num in array)
        {
            if (num > x && num < y)
            {
                return num;
            }
        }
        return x;
    }
}
