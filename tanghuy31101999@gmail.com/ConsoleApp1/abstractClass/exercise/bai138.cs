using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai138 : AbstractClass
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
            int position = -1;

            for (int i = 0; i < length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    position = i;
                    break;
                }
            }

            return position;
        }
    }
}
