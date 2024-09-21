using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai155 : AbstractClass
    {

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double x = 2;

            double value = FindValue(array, x);

            Console.WriteLine("Ket qua: " + value);
        }

        private double FindValue(double[] array, double x)
        {
            double maxDistance = double.MinValue;
            double maxDistanceValue = 0;

            foreach (double value in array)
            {
                double distance = Math.Abs(value - x);

                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    maxDistanceValue = value;
                }
            }

            return maxDistanceValue;
        }

       
    }


}
