namespace Week3.Day_38_16_09_2024;

public class Bai162 : Homework
{
    public override void Run()
    {
        double[] doubleArray = InputDoubleArray.GetDoubleArray(); 
        int position = FindPositionWithNeighborProduct(doubleArray);
        if (position == -1)
        {
            Console.WriteLine("Khong co vi tri nao thoa man dieu kien.");
        }
        else
        {
            Console.WriteLine("Vi tri co gia tri bang tich hai gia tri lan can la: " + position);
        }
    }

    private int FindPositionWithNeighborProduct(double[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] == array[i - 1] * array[i + 1])
            {
                return i;
            }
        }
        return -1; 
    }
}
