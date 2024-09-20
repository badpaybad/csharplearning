using AbstractClassNameSpace;
using SupportNamespace;

namespace Abclass.Exercise
{
    public class Bai145 : AbstractClass
    {
        private bool IsPerfectNumber(int number)
        {
            if (number <= 1) return false;

            int sum = 1;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (i == number / i)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i + number / i;
                    }
                }
            }

            return sum == number;
        }

        private int FindFirstPerfectNumber(int[] array)
        {
            foreach (int number in array)
            {
                if (IsPerfectNumber(number))
                {
                    return number;
                }
            }

            return -1;
        }

        public override void Run()
        {
            int[] array = SupportInputData.GetArrInt();

            int firstPerfectNumber = FindFirstPerfectNumber(array);

            if (firstPerfectNumber == -1)
            {
                Console.WriteLine("Khong co gia tri so hoan thien trong mang.");
            }
            else
            {
                Console.WriteLine("So hoan thien dau tien trong mang la: " + firstPerfectNumber);
            }
        }
    }
}
