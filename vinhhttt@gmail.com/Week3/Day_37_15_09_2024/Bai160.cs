namespace Week3.Day_37_15_09_2024;

public class Bai160 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray(); 
        double lastValue = FindLastNegativeGreaterThanMinus1(doubleArray);
        if (lastValue == 0)
        {
            Console.WriteLine("Khong co gia tri am nao lon hon -1.");
        }
        else
        {
            Console.WriteLine("Gia tri am cuoi cung lon hon -1 la: " + lastValue);
        }
    }

    private double FindLastNegativeGreaterThanMinus1(double[] array)
    {
        double result = 0;
        foreach (double num in array)
        {
            if (num < 0 && num > -1)
            {
                result = num;
            }
        }
        return result;
    }
}
