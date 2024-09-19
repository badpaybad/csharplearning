using System;
namespace abclass.exercise
{
    public class Bai150 : AbstractClass
    {
        private double FindMaxNegative(double[] array)
        {
            double maxNegative = double.MinValue;
            bool foundNegative = false;

            foreach (double number in array)
            {
                if (number < 0)
                {
                    if (!foundNegative || number > maxNegative)
                    {
                        maxNegative = number;
                        foundNegative = true;
                    }
                }
            }

            return foundNegative ? maxNegative : 0;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxNegative = FindMaxNegative(array);

            Console.WriteLine("Gia tri am lon nhat trong mang la: " + maxNegative);
        }
    }
}
