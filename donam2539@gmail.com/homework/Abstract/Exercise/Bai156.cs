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
    public class Bai156 : AbstractClass
    {
        private int FindIndexOfClosestValue(double[] array, double x)
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

        public override void Run()
        {
            double[] array = SupportInputData.GetArrDouble();


            Console.Write("Nhap gia tri x: ");
            double x = double.Parse(Console.ReadLine());

            int index = FindIndexOfClosestValue(array, x);

            Console.WriteLine("Vi tri cua gia tri gan x nhat trong mang la: " + index);
        }
    }
}
