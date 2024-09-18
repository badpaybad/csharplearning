namespace Week3.Day_37_15_09_2024;

public class Bai159 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray(); 
        double firstValue = FindFirstValueGreaterThan2003(doubleArray);
        if (firstValue == 0)
        {
            Console.WriteLine("Khong co gia tri nao lon hon 2003.");
        }
        else
        {
            Console.WriteLine("Gia tri dau tien lon hon 2003 la: " + firstValue);
        }
    }

    private double FindFirstValueGreaterThan2003(double[] array)
    {
        foreach (double num in array)
        {
            if (num > 2003)
            {
                return num;
            }
        }
        return 0; // Neu khong co gia tri nao thoa man
    }
}
