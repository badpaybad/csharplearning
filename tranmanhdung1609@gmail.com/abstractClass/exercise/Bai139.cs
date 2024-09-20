using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai139 : AbstractClass
    {
        private bool IsPerfectNumber(int number)
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

        private int FindPositionOfLastPerfect(int[] array)
        {
            int lastPosition = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPerfectNumber(array[i]))
                {
                    lastPosition = i;
                }
            }
            return lastPosition;
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int perfectPosition = FindPositionOfLastPerfect(array);

            if (perfectPosition == -1)
            {
                Console.WriteLine("Khong co so hoan thien trong mang.");
            }
            else
            {
                Console.WriteLine("Vi tri cua so hoan thien cuoi cung trong mang la: " + perfectPosition);
                Console.WriteLine("So hoan thien cuoi cung la: " + array[perfectPosition]);
            }
        }
    }
}
