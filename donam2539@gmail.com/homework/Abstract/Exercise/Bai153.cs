using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai153 : AbstractClass
    {
        private int FindMinEven(int[] array)
        {
            int minEven = int.MaxValue;
            bool foundEven = false;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    if (!foundEven || number < minEven)
                    {
                        minEven = number;
                        foundEven = true;
                    }
                }
            }

            return foundEven ? minEven : -1;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int minEven = FindMinEven(array);

            Console.WriteLine("Gia tri chan nho nhat trong mang la: " + minEven);
        }
    }
}
