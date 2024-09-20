using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai152 : AbstractClass
    {
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

        private int FindMinPerfectNumber(int[] array)
        {
            int minPerfect = int.MaxValue;
            bool foundPerfect = false;

            foreach (int number in array)
            {
                if (IsPerfectNumber(number))
                {
                    if (number < minPerfect)
                    {
                        minPerfect = number;
                        foundPerfect = true;
                    }
                }
            }

            return foundPerfect ? minPerfect : 0;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int minPerfect = FindMinPerfectNumber(array);

            Console.WriteLine("So hoan thien nho nhat trong mang la: " + minPerfect);
        }
    }
}
