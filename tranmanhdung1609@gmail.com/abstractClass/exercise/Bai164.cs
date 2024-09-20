using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai164:AbstractClass
    {
        private bool IsPalindrome(int num)
        {
            string numStr = num.ToString();
            string reversedStr = new string(numStr.Reverse().ToArray());
            return numStr == reversedStr;
        }

        public int FindFirstPalindrome(int[] array)
        {
            foreach (int num in array)
            {
                if (IsPalindrome(num))
                {
                    return num;
                }
            }
            return -1;
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int result = FindFirstPalindrome(array);
            Console.WriteLine($"Gia tri dau tien thoa tinh chat so ganh la: {result}");
        }
    }
}
