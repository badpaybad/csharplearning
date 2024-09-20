using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai135 : AbstractClass
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
            double rs = -1;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > 0)
                {
                    rs = array[i];
                    break;
                }
            }

            return rs;
        }
    }
}
