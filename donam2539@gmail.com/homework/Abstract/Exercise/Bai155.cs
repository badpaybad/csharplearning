using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai155 : AbstractClass
    {
        private double FindMaxDistanceValue(double[] array, double x)
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

        public override void Run()
        {
            double[] array = SupportInputData.GetArrDouble();

            Console.Write("Nhap gia tri x: ");
            double x = double.Parse(Console.ReadLine());

            double maxDistanceValue = FindMaxDistanceValue(array, x);

            Console.WriteLine("Gia tri trong mang xa gia tri x nhat la: " + maxDistanceValue);
        }
    }
}
