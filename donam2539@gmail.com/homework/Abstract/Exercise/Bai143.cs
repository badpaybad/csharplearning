using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai143 : AbstractClass
    {
        private int FindFirstEven(int[] array)
        {
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    return number;
                }
            }

            return -1;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int firstEven = FindFirstEven(array);

            if (firstEven == -1)
            {
                Console.WriteLine("Khong co gia tri chan trong mang.");
            }
            else
            {
                Console.WriteLine("So chan dau tien trong mang la: " + firstEven);
            }
        }
    }
}
