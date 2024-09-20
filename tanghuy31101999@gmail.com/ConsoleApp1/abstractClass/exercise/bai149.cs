
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai149 : AbstractClass
    {
        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int lastPerfectNumber = FindLastValue(array);

            Console.WriteLine("Ket qua: " + lastPerfectNumber);
        }
        private bool IsPerfectNumber(int number)
        {
            if (number <= 1) return false;

            int sum = 1;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    sum += i;

                    if (i != number / i)
                    {
                        sum += number / i;
                    }
                }
            }

            return sum == number;
        }

        private int FindLastValue(int[] array)
        {
            int data = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPerfectNumber(array[i]))
                {
                    data = array[i];
                }
            }

            return data;
        }

        
    }
}
