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
    public class Bai151 : AbstractClass
    {
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        private int FindMaxPrime(int[] array)
        {
            int maxPrime = 0;
            bool foundPrime = false;

            foreach (int number in array)
            {
                if (IsPrime(number))
                {
                    if (!foundPrime || number > maxPrime)
                    {
                        maxPrime = number;
                        foundPrime = true;
                    }
                }
            }

            return foundPrime ? maxPrime : 0;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int maxPrime = FindMaxPrime(array);

            Console.WriteLine("So nguyen to lon nhat trong mang la: " + maxPrime);
        }
    }
}
