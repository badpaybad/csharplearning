using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution156: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 156 ----");
        double number  = SupportInputData.GetDouble();
        double[] array = SupportInputData.GetArrDouble();
        double result  = getNearestValue(number, array);
        SupportDisplay.Display(result, "Bài 156: Giá trị gần nhất là");
    }

    private double getNearestValue(double number, double[] array)
    {
        double distance = double.MaxValue;
        double nearest  = 0;
        foreach (double value in array)
        {
            double currentDistance = Math.Abs(number - value);
            if (currentDistance < distance)
            {
                distance = currentDistance;
                nearest = value;
            }
        }

        return nearest;
    }
}