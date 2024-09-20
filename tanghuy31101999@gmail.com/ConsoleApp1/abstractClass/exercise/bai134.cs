using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai134 : AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxValue = FindMax(array);

            Console.WriteLine("Ket qua: " + maxValue);
        }

        private double FindMax(double[] array)
        {
            int length = array.Length;
            double max = 0.0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}