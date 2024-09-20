using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution158: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 158 ----");
        double[] array  = SupportInputData.GetArrDouble();
        double[] result = getGreatestNumber(array);
        SupportDisplay.DisplayArrayDouble(result, "Bài 158: Đoạn [-x, x] là");
    }

    private double[] getGreatestNumber(double[] array)
    {
        double max = array.Max();
        double min = array.Min();
        
        return Math.Abs(max) > Math.Abs(min)
            ? [-max, max]
            : [min, -min];
    }
}