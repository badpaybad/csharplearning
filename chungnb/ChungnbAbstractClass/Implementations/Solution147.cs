using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution147: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 147 ----");
        double[] array = SupportInputData.GetArrDouble();
        double number  = getLastPositiveNumber(array);
        SupportDisplay.Display(number, "Bài 147: Số dương cuối cùng là");
    }

    private double getLastPositiveNumber(double[] array)
    {
        double number = -1;
        foreach (int value in array)
        {
            if (value % 2 == 0)
            {
                number = value;
            }
        }

        return number;
    }
}