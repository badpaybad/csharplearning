using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai140 : AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxValue = FindValueMax(array);

            Console.WriteLine("Ket qua: " + maxValue);
        }

        private double FindValueMax(double[] array)
        {
            int length = array.Length;
            double maxValue = double.MaxValue;
            double data = -1;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > 0 && array[i] < maxValue)
                {
                    data = array[i];
                }
            }

            return data;
        }
    }
}
