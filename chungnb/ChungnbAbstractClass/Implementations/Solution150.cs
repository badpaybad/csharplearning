using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution150: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 150 ----");
        double[] array = SupportInputData.GetArrDouble();
        double number  = getGreatestNegativeNumber(array);
        SupportDisplay.Display(number, "Bài 150: Số âm lớn nhất là");
    }

    private double getGreatestNegativeNumber(double[] array)
    {
        double number = 0;
        foreach (double value in array)
        {
            if (value < 0 && value < number)
            {
                number = value;
            }
        }

        return number;
    }
}