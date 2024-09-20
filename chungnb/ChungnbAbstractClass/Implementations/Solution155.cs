using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution155: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 155 ----");
        double number  = SupportInputData.GetDouble();
        double[] array = SupportInputData.GetArrDouble();
        double result  = getFathestValue(number, array);
        SupportDisplay.Display(result, "Bài 155: Giá trị xa nhất là");
    }

    private double getFathestValue(double number, double[] array)
    {
        double distance = 0;
        double farthest = 0;
        foreach (double value in array)
        {
            double currentDistance = Math.Abs(number - value);
            if (currentDistance > distance)
            {
                distance = currentDistance;
                farthest = value;
            }
        }

        return farthest;
    }
}