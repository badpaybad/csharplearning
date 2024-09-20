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
    public class Bai144 : AbstractClass
    {
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        private int FindFirstPrime(int[] array)
        {
            foreach (int number in array)
            {
                if (IsPrime(number))
                {
                    return number;
                }
            }

            return -1;
        }

        // Method to run input/output logic
        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int firstPrime = FindFirstPrime(array);

            if (firstPrime == -1)
            {
                Console.WriteLine("Khong co gia tri nguyen to trong mang.");
            }
            else
            {
                Console.WriteLine("So nguyen to dau tien trong mang la: " + firstPrime);
            }
        }
    }
}
