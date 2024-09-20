using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai147 : AbstractClass
    {
        private double FindLastPositive(double[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    return array[i];
                }
            }

            return -1;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double lastPositive = FindLastPositive(array);

            if (lastPositive == -1)
            {
                Console.WriteLine("Khong co gia tri duong trong mang.");
            }
            else
            {
                Console.WriteLine("So duong cuoi cung trong mang la: " + lastPositive);
            }
        }
    }
}
