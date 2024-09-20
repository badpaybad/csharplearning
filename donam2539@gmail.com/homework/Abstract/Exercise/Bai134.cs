using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractClassNameSpace;
using SupportNamespace;
// using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai134 : AbstractClass
    {
        private double FindMax(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public override void Run()
        {
            double[] array = SupportInputData.GetArrDouble();

            double maxValue = FindMax(array);

            Console.WriteLine("Gia tri lon nhat: " + maxValue);
        }
    }
}
