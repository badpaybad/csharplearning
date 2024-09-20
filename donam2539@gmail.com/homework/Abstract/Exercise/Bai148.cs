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
    public class Bai148 : AbstractClass
    {
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;

            if (number == 2) return true;

            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private int FindLastPrime(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (IsPrime(array[i]))
                {
                    return array[i];
                }
            }

            return -1;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int lastPrime = FindLastPrime(array);

            if (lastPrime == -1)
            {
                Console.WriteLine("Khong co so nguyen to trong mang.");
            }
            else
            {
                Console.WriteLine("So nguyen to cuoi cung trong mang la: " + lastPrime);
            }
        }
    }
}
