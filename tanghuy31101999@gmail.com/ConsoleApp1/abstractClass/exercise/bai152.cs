using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai152 : AbstractClass
    {

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxNegative = FindValue(array);

            Console.WriteLine("Ket qua: " + maxNegative);
        }
        private double FindValue(double[] array)
        {
            int data = 0; 

            foreach (int num in array)
            {
                if (IsPerfect(num) && (data == 0 || num < data))
                {
                    data = num;
                }
            }

            return data;
        }

        private bool IsPerfect(int number)
        {
            if (number <= 0)
            {
                return false;
            }

            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }


    }
}
