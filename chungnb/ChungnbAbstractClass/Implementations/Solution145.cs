using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution145: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 144 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getFirstPerfectNumber(array);
        SupportDisplay.Display(number, "Bài 145: Số hoàn thiện đầu tiên là");
    }

    private int getFirstPerfectNumber(int[] array)
    {
        int number = -1;
        foreach (int value in array)
        {
            if (SupportMath.IsPerfectNumber(value))
            {
                number = value;
                break;
            }
        }

        return number;
    }
}