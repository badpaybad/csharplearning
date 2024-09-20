using AbstractClassNameSpace;
using SupportNamespace;


namespace Abclass.Exercise
{
    public class Bai135 : AbstractClass
    {
        public override void Run()
        {
            double[] array = SupportInputData.GetArrDouble();

            double maxValue = FindFirstPositive(array);

            Console.WriteLine("Gia tri duong dau tien: " + maxValue);
        }

        private double FindFirstPositive(double[] array)
        {
            foreach (var value in array)
            {
                if (value > 0)
                {
                    return value;
                }
            }
            return -1;
        }
    }
}
