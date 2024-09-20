using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai142 : AbstractClass
    {
        private double FindSmallestValue(double[] array)
        {
            double minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double minValue = FindSmallestValue(array);
            Console.WriteLine("Gia tri nho nhat trong mang la: " + minValue);
        }
    }
}
