using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution153: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 153 ----");
        int[] array = SupportInputData.GetArrInt();
        int number  = getSmallestEvenNumber(array);
        SupportDisplay.Display(number, "Bài 153: Số chẵn nhỏ nhất là");
    }

    private int getSmallestEvenNumber(int[] array)
    {
        int number   = int.MaxValue;
        bool isFound = false;
        foreach (int value in array)
        {
            if (value % 2 == 0 && value < number)
            {
                number  = value;
                isFound = true;
            }
        }

        return isFound ? number : -1;
    }
}