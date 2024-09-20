using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution144: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 144 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getFirstPrimeNumber(array);
        SupportDisplay.Display(number, "Bài 144: Số nguyên tố đầu tiên là");
    }

    private int getFirstPrimeNumber(int[] array)
    {
        int number = -1;
        foreach (int value in array)
        {
            if (SupportMath.IsPrime(value))
            {
                number = value;
                break;
            }
        }

        return number;
    }
}