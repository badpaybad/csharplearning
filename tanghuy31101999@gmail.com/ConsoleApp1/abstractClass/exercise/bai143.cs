using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai143 : AbstractClass
    {

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int firstEven = FindFirstEven(array);

             Console.WriteLine("Ket qua: " + firstEven);
        }

        private int FindFirstEven(int[] array)
        {
            int item = -1;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    item = number;
                    break;
                }
            }
            return item;
        }

        
    }
}
