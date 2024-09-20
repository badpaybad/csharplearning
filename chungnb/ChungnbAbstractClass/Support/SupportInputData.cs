using System.Transactions;

namespace ChungnbAbstractClass.Support;

internal class SupportInputData
{
    public static int GetInt()
    {
        Console.Write("Nhập số nguyên: ");
        int.TryParse(Console.ReadLine(), out int number);
        return number;
    }

    public static double GetDouble()
    {
        Console.Write("Nhập số thực, ngăn cách thập phân bằng dấu ',': ");
        double.TryParse(Console.ReadLine(), out double number);
        return number;
    }
    
    public static int[] GetArrInt()
    {
        int length = GetArrLength();

        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Nhập số nguyên thứ {i+1}: ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        return arr;
    }

    public static double[] GetArrDouble()
    {
        int length = GetArrLength();

        double[] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Nhập số thực thứ {i+1}, ngăn cách thập phân bằng dấu ',': ");
            double.TryParse(Console.ReadLine(), out arr[i]);
        }

        return arr;
    }
    
    private static int GetArrLength()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int.TryParse(Console.ReadLine(), out int length);
        CheckArrLength(length);
        return length;
    }
    
    private static void CheckArrLength(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine("Số phần tử của mảng phải >= 1");
            throw new ArgumentOutOfRangeException();
        }
    }
}
