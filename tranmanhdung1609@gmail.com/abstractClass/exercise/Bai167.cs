using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai167:AbstractClass
    {
        private bool AllDigitsOdd(int num)
        {
            num = Math.Abs(num);

            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    return false;
                }
                num /= 10;
            }
            return true;
        }

        public int FindMaxOddDigitValue(int[] array)
        {
            int max = 0;
            bool found = false;

            foreach (int num in array)
            {
                if (AllDigitsOdd(num))
                {
                    if (!found || num > max)
                    {
                        max = num;
                        found = true;
                    }
                }
            }

            return found ? max : 0;
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int result = FindMaxOddDigitValue(array);
            Console.WriteLine($"Giá trị lớn nhất thỏa điều kiện là: {result}");
        }
    }
}
