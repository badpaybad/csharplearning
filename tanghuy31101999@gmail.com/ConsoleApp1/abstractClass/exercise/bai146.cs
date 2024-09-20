using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{

    public class Bai146: AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double firstPerfectNumber = FindFirstValue(array);

            Console.WriteLine("Ket qua: " + firstPerfectNumber);
        }

        private double FindFirstValue(double[] array)
        {
            double data = 1;
            foreach (double number in array)
            {
                if (number < 0)
                {
                    data = number;
                    break;
                }
            }

            return data;
        }
    }
    
}
