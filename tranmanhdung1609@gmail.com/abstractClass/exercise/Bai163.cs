using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai163: AbstractClass
    {
        private bool IsPerfectSquare(int num)
        {
            if (num < 0) return false;
            int sqrt = (int)Math.Sqrt(num);
            return (sqrt * sqrt == num);
        }

        public int FindFirstPerfectSquare(int[] array)
        {
            foreach (int num in array)
            {
                if (IsPerfectSquare(num))
                {
                    return num;
                }
            }
            return -1;
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int result = FindFirstPerfectSquare(array);
            Console.WriteLine($"So chinh phuong dau tien la: {result}");
        }
    }
}
