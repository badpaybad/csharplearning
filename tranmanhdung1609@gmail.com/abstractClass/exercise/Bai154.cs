using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai154 : AbstractClass
    {
        private int FindIndexOfMaxNegative(double[] array)
        {
            double maxNegative = double.MinValue;
            int indexOfMaxNegative = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] > maxNegative)
                {
                    maxNegative = array[i];
                    indexOfMaxNegative = i;
                }
            }

            return indexOfMaxNegative;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double index = FindIndexOfMaxNegative(array);

            Console.WriteLine("Vi tri cua gia tri am lon nhat trong mang la: " + index);
        }
    }
}
