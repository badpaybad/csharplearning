using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai136 : AbstractClass
    {
        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int maxValue = FindMax(array);

            Console.WriteLine("Ket qua: " + maxValue);
        }

        private int FindMax(int[] array)
        {
            int length = array.Length;
            int rs = 1;

            for (int i = 0; i < length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    rs = array[i];
                }
            }

            return rs;
        }
    }
}
