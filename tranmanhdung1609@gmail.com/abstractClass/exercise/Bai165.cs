using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai165:AbstractClass
    {
        private bool HasOddFirstDigit(int num)
        {
            string numStr = Math.Abs(num).ToString();
            int firstDigit = int.Parse(numStr[0].ToString());
            return firstDigit % 2 != 0;
        }

        public int FindFirstOddDigitNumber(int[] array)
        {
            foreach (int num in array)
            {
                if (HasOddFirstDigit(num))
                {
                    return num;
                }
            }
            return 0;
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int result = FindFirstOddDigitNumber(array);
            Console.WriteLine($"Gia tri dau tien co chu so dau tien la so le la: {result}");
        }
    }
}
