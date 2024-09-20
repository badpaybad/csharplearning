using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai154 : AbstractClass
    {

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double index = FindIndex(array);

            Console.WriteLine("Ket qua: " + index);
        }

        private int FindIndex(double[] array)
        {
            int index = -1; 
            double maxNegativeValue = double.MinValue; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] > maxNegativeValue)
                {
                    maxNegativeValue = array[i];
                    index = i; 
                }
            }

            return index;
        }

        
    }
}
