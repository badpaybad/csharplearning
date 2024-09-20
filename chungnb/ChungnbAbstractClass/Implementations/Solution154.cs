using ChungnbAbstractClass.Abstraction;
using ChungnbAbstractClass.Support;

namespace ChungnbAbstractClass.Implementations;

internal class Solution154: AbstractSolutions
{
    public override void Run()
    {
        Console.WriteLine("---- Bài 154 ----");
        double[] array = SupportInputData.GetArrDouble();
        double number  = getIndexOfGreatestNegativeNumber(array);
        SupportDisplay.Display(number, "Bài 154: Vị trí số thực âm lớn nhất là");
    }

    private double getIndexOfGreatestNegativeNumber(double[] array)
    {
        double number = 0;
        double index = 0;
        bool isFound  = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (
                isFound == false && array[i] < number
                || isFound && array[i] < 0 && array[i] > number
            )
            {
                index = i;
                number = array[i];
                isFound = true;
            }
        }

        return isFound ? index : -1;
    }
}