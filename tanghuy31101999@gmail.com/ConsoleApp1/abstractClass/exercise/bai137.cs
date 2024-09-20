using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai137 : AbstractClass
    {
        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int maxValue = FindPosition(array);

            Console.WriteLine("Ket qua: " + maxValue);
        }

        private int FindPosition(int[] array)
        {
            int length = array.Length;
            double min = array[0];
            int position = 0;

            for (int i = 1; i < length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    position = i;
                }
            }
            return position;
        }
    }
}
