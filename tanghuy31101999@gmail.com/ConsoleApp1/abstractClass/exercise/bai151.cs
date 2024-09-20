using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class bai151: AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxNegative = FindValue(array);

            Console.WriteLine("Ket qua: " + maxNegative);
        }
        private double FindValue(double[] array)
        {
            int maxPrime = 0; 

            foreach (int num in array)
            {
                if (IsPrime(num) && num > maxPrime)
                {
                    maxPrime = num;
                }
            }

            return maxPrime;
        }

        private  bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    } 
}
