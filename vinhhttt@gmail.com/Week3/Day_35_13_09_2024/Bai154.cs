namespace Week3.Day_35_13_09_2024;

public class Bai154 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray(); 
        int position = FindPositionOfLargestNegative(doubleArray);
        if (position == -1)
        {
            Console.WriteLine("Mang khong co gia tri am.");
        }
        else
        {
            Console.WriteLine("Vi tri gia tri am lon nhat trong mang la: " + position);
        }
    }

    private int FindPositionOfLargestNegative(double[] array)
    {
        double maxNegative = double.MinValue;
        int position = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && array[i] > maxNegative)
            {
                maxNegative = array[i];
                position = i;
            }
        }
        return position;
    }
}

