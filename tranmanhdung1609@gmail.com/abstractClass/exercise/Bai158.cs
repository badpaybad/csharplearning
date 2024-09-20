using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai158 : AbstractClass
    {
        private double FindX(double[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            double maxAbsValue = Math.Abs(array[0]);

            foreach (double value in array)
            {
                double absValue = Math.Abs(value);
                if (absValue > maxAbsValue)
                {
                    maxAbsValue = absValue;
                }
            }

            return maxAbsValue;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double x = FindX(array);

            Console.WriteLine($"Gia tri x sao cho doan [-x, x] chua tat ca cac gia tri trong mang la: {x}");
        }
    }
}
