using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution157: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 157 ----");
        double[] array  = SupportInputData.GetArrDouble();
        double[] result = getDoubleRangeArray(array);
        SupportDisplay.DisplayArrayDouble(result, "Bài 157: Đoạn [a, b] là");
    }

    private double[] getDoubleRangeArray(double[] array)
    {
        double min = array.Min();
        double max = array.Max();
        return [min, max];
    }
}