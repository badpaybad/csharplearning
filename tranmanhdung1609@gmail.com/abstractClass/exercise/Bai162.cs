using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abclass.exercise
{
    public class Bai162 : AbstractClass
    {
        public int FindPosition(double[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                double left = array[i - 1];
                double right = array[i + 1];
                if (array[i] == left * right)
                {
                    return i;
                }
            }
            return -1;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            int position = FindPosition(array);
            Console.WriteLine($"Vi tri thoa man dieu kien la: {position}");
        }
    }
}
