namespace Week3.Day_29_07_09_2024;

public class Bai136 : Homework
{
    public override void Run()
    {
        
        int[] intArray = InputIntArray.GetInputIntArray();
        int lastEven = FindLastEvenValue(intArray);
        if (lastEven == -1)
        {
            Console.WriteLine("Mang khong co gia tri chan.");
        }
        else
        {
            Console.WriteLine("So chan cuoi cung trong mang la: " + lastEven);
        }
        
    }
    
    private  static int FindLastEvenValue(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == 0)
            {
                return array[i];
            }
        }
        return -1;
    }

}