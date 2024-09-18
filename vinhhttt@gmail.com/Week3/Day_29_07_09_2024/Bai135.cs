namespace Week3.Day_29_07_09_2024;

public class Bai135 : Homework
{
    public override void Run()
    {
        
        double[] doubleArrayForPositive = InputDoubleArray.GetDoubleArray();
        double firstPositive = FindFirstPositiveValue(doubleArrayForPositive);
        if (firstPositive == -1)
        {
            Console.WriteLine("Mang khong co gia tri duong.");
        }
        else
        {
            Console.WriteLine("Gia tri duong dau tien trong mang la: " + firstPositive);
        }
    }
    
    
    private static double FindFirstPositiveValue(double[] array)
    {
        foreach (double num in array)
        {
            if (num > 0)
            {
                return num;
            }
        }
        return -1;
    }
}