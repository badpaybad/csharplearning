using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution148: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 148 ----");
        double[] array = SupportInputData.GetArrDouble();
        double number  = getLastPositiveNumber(array);
        SupportDisplay.Display(number, "Bài 148: Số dương cuối cùng là");
    }

    private double getLastPositiveNumber(double[] array)
    {
        double number = -1;
        foreach (double value in array)
        {
            if (value > 0)
            {
                number = value;
            }
        }

        return number;
    }
}