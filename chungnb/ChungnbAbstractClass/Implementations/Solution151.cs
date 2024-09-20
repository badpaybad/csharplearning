using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution151: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 151 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getGreatestPrimeNumber(array);
        SupportDisplay.Display(number, "Bài 151: Số nguyên tố lớn nhất là");
    }

    private int getGreatestPrimeNumber(int[] array)
    {
        int number = 0;
        foreach (int value in array)
        {
            if (SupportMath.IsPrime(value) && value > number)
            {
                number = value;
            }
        }

        return number;
    }
}