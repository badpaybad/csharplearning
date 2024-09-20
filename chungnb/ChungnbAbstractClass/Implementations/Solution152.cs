using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution152: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 152 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getSmallestPerfectNumber(array);
        SupportDisplay.Display(number, "Bài 152: Số hoàn thiện nhỏ nhất là");
    }

    private int getSmallestPerfectNumber(int[] array)
    {
        int number   = int.MaxValue;
        bool isFound = false;
        foreach (int value in array)
        {
            if (SupportMath.IsPerfectNumber(value) && value < number)
            {
                number  = value;
                isFound = true;
            }
        }

        return isFound ? number : -1;
    }
}