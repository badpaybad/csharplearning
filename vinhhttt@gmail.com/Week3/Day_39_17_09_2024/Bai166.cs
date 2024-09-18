namespace Week3.Day_39_17_09_2024;

public class Bai166 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray(); 
        int powerOfTwo = FindFirstPowerOfTwo(intArray);
        if (powerOfTwo == 0)
        {
            Console.WriteLine("Khong co so nao co dang 2^k.");
        }
        else
        {
            Console.WriteLine("So dau tien co dang 2^k la: " + powerOfTwo);
        }
    }

    private int FindFirstPowerOfTwo(int[] array)
    {
        foreach (int num in array)
        {
            if (IsPowerOfTwo(num))
            {
                return num;
            }
        }
        return 0; 
    }

    private bool IsPowerOfTwo(int num)
    {
        if (num <= 0) return false;
        return (num & (num - 1)) == 0;
    }
}
