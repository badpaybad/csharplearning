using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai156 : AbstractClass
    {

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double x = 1;

            int index = FindIndex(array, x);

            Console.WriteLine("Ket qua: " + index);
        }

        private int FindIndex(double[] array, double x)
        {
            double minDistance = double.MaxValue;
            int indexOfClosestValue = -1;

            for (int i = 0; i < array.Length; i++)
            {
                double distance = Math.Abs(array[i] - x);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    indexOfClosestValue = i;
                }
            }

            return indexOfClosestValue;
        }

       


    }
}
