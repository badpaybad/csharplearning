using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai138 : AbstractClass
    {
        private int FindPositionOfFirstEven(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int evenPosition = FindPositionOfFirstEven(array);

            if (evenPosition == -1)
            {
                Console.WriteLine("Khong co gia tri chan trong mang.");
            }
            else
            {
                Console.WriteLine("Vi tri cua gia tri chan dau tien trong mang la: " + evenPosition);
                Console.WriteLine("Gia tri chan dau tien la: " + array[evenPosition]);
            }
        }
    }
}
