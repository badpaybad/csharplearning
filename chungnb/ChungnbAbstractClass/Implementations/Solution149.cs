using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution149: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 149 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getLastPerfectNumber(array);
        SupportDisplay.Display(number, "Bài 149: Số hoàn thiện cuối cùng là");
    }

    private int getLastPerfectNumber(int[] array)
    {
        int number = -1;
        foreach (int value in array)
        {
            if (SupportMath.IsPerfectNumber(value))
            {
                number = value;
            }
        }

        return number;
    }
}