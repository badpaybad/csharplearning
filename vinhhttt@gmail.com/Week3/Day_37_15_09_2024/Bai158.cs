namespace Week3.Day_37_15_09_2024;

public class Bai158 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray(); 
        double x = FindXForInterval(doubleArray);
        Console.WriteLine("Gia trị x sao cho doan [-x, x] chua tat ca cac gia tri trong mang la: " + x);
    }

    private double FindXForInterval(double[] array)
    {
        double maxAbsValue = 0;

        foreach (double num in array)
        {
            double absValue = Math.Abs(num);
            if (absValue > maxAbsValue)
            {
                maxAbsValue = absValue;
            }
        }

        return maxAbsValue;
    }
}
