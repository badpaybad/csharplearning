using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai153 : AbstractClass
    {

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int value = FindValue(array);

            Console.WriteLine("Ket qua: " + value);
        }

        private int FindValue(int[] array)
        {
            int minEven = int.MaxValue;
            bool foundEven = false;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    if (!foundEven || number < minEven)
                    {
                        minEven = number;
                        foundEven = true;
                    }
                }
            }

            return foundEven ? minEven : -1;
        }

        
    }
}
