using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abclass;

namespace abstractClass.exercise
{
    public class Bai145 : AbstractClass
    {

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int firstPerfectNumber = FindFirstValue(array);

            Console.WriteLine("Ket qua: " + firstPerfectNumber);
        }


        private int FindFirstValue(int[] array)
        {
            int data = -1;
            foreach (int number in array)
            {
                if (IsPrime(number))
                {
                    data = number;
                    break;
                }
            }

            return data;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;

            int sum = 1;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (i == number / i)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i + number / i;
                    }
                }
            }

            return sum == number;
        }

        

       
    }
}
