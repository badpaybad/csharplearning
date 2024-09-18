namespace Week3.Day_38_16_09_2024;

public class Bai163 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray();
        int perfectSquare = FindFirstPerfectSquare(intArray);
        if (perfectSquare == -1)
        {
            Console.WriteLine("Khong co so chinh phuong trong mang.");
        }
        else
        {
            Console.WriteLine("So chinh phuong dau tien trong mang la: " + perfectSquare);
        }
    }

    private int FindFirstPerfectSquare(int[] array)
    {
        foreach (int num in array)
        {
            if (IsPerfectSquare(num))
            {
                return num;
            }
        }
        return -1; 
    }

    private bool IsPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }
}
