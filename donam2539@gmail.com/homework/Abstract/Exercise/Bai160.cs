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
    public class Bai160:AbstractClass
    {
        private double FindLastNegativeGreaterThanMinusOne(double[] array)
        {
            double result = 0;
            bool found = false;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0 && array[i] > -1)
                {
                    result = array[i];
                    found = true;
                    break;
                }
            }

            return found ? result : 0;
        }

        public override void Run()
        {
            double[] array = SupportInputData.GetArrDouble();

            double result = FindLastNegativeGreaterThanMinusOne(array);

            Console.WriteLine($"Giá trị âm cuối cùng lớn hơn -1 trong mảng là: {result}");
        }
    }
}
