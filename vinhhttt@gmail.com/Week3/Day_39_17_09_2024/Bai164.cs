namespace Week3.Day_39_17_09_2024;

public class Bai164 : Homework
{
    public override void Run()
    {
        int[] intArray = InputIntArray.GetInputIntArray(); 
        int ganhNumber = FindFirstGanhNumber(intArray);
        if (ganhNumber == -1)
        {
            Console.WriteLine("Khong co so ganh trong mang.");
        }
        else
        {
            Console.WriteLine("So ganh dau tien trong mang la: " + ganhNumber);
        }
    }

    private int FindFirstGanhNumber(int[] array)
    {
        foreach (int num in array)
        {
            if (IsGanhNumber(num))
            {
                return num;
            }
        }
        return -1; 
    }

    private bool IsGanhNumber(int num)
    {
        string s = num.ToString();
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return s == new string(charArray);
    }
}
