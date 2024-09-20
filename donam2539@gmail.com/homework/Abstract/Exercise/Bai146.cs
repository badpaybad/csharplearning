using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai146 : AbstractClass
    {
        private double FindFirstNegative(double[] array)
        {
            foreach (double number in array)
            {
                if (number < 0)
                {
                    return number;
                }
            }

            return 1;
        }

        public override void Run()
        {
            double[] array = SupportInputData.GetArrDouble();

            double firstNegative = FindFirstNegative(array);

            if (firstNegative == 1)
            {
                Console.WriteLine("Khong co gia tri am trong mang.");
            }
            else
            {
                Console.WriteLine("Gia tri am dau tien trong mang la: " + firstNegative);
            }
        }
    }
}
