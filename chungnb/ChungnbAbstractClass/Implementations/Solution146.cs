using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution146: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 146 ----");
        double[] array = SupportInputData.GetArrDouble();
        double number  = getFirstNegativeNumber(array);
        SupportDisplay.Display(number, "Bài 146: Số thực âm đầu tiên là");
    }

    private double getFirstNegativeNumber(double[] array)
    {
        double number = 1;
        foreach (int value in array)
        {
            if (value < 0)
            {
                number = value;
                break;
            }
        }

        return number;
    }
}