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
    public class Bai149 : AbstractClass
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

        private int FindLastPerfectNumber(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPerfectNumber(array[i]))
                {
                    return array[i];
                }
            }

            return -1;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int lastPerfectNumber = FindLastPerfectNumber(array);

            if (lastPerfectNumber == -1)
            {
                Console.WriteLine("Khong co so hoan thien trong mang.");
            }
            else
            {
                Console.WriteLine("So hoan thien cuoi cung trong mang la: " + lastPerfectNumber);
            }
        }
    }
}
