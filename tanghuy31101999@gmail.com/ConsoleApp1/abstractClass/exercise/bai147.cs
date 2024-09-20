using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai147 : AbstractClass
    {

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double lastPositive = FindLastPositive(array);

            Console.WriteLine("Ket qua: " + lastPositive);
        }
        private double FindLastPositive(double[] array)
        {
            double data = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    data = array[i];
                }
            }

            return data;
        }

        
    }
}
