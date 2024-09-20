using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai150 : AbstractClass
    {

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxNegative = FindMaxNegative(array);

            Console.WriteLine("Ket qua: " + maxNegative);
        }
        private double FindMaxNegative(double[] array)
        {
            double maxNegative = 0; // Giá trị mặc định nếu không có số âm

            foreach (double num in array)
            {
                // Nếu số hiện tại là âm và lớn hơn maxNegative (hoặc maxNegative vẫn là 0)
                if (num < 0 && (maxNegative == 0 || num > maxNegative))
                {
                    maxNegative = num;
                }
            }
            return maxNegative;
        }

        
    }
}
