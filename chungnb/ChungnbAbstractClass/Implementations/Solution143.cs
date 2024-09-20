using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution143: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 143 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getFirstEvenNumber(array);
        SupportDisplay.Display(number, "Bài 143: Số chẵn đầu tiên là");
    }

    private int getFirstEvenNumber(int[] array)
    {
        int number = -1;
        foreach (int value in array)
        {
            if (value % 2 == 0)
            {
                number = value;
                break;
            }
        }

        return number;
    }
}