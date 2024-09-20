using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution159: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 159 ----");
        double[] array = SupportInputData.GetArrDouble();
        double result  = getFirstGreaterNumber(array);
        SupportDisplay.Display(result, "Bài 159: Giá trị đầu tiên lớn hơn 2003 là");
    }

    private double getFirstGreaterNumber(double[] array)
    {
        double milestone          = 2003;
        double firstGreaterNumber = 0;
        foreach (double value in array)
        {
            if (value > milestone)
            {
                firstGreaterNumber = value;
            }
        }
        return firstGreaterNumber;
    }
}