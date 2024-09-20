using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution142: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 142 ----");
        double[] array = SupportInputData.GetArrDouble();
        double min     = getMinInDoubleArray(array);
        SupportDisplay.Display(min, "Bài 142: Số nhỏ nhất là");
    }

    private double getMinInDoubleArray(double[] array)
    {
        double min = array[0];
        foreach (double value in array)
        {
            if (value < min)
            {
                min = value;
            }
        }

        return min;
    }
}