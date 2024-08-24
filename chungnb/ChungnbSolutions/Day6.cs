using System;
using SupportNamespace;

namespace DaySixNamespace
{
    class DaySix
    {
        public static void Solutions()
        {
            int day = 6;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(2, 1);
            ProblemTwo(2, 2);
            ProblemThree(2, 1);
        }

        private static void ProblemOne(int n, int x)
        {
            if (n <= 0)
            {
                Console.WriteLine("Bài số 16: Input n phải >= 1");
                return;
            }

            double rs          = 0;
            double numerator   = 0;
            double denominator = 0;
            for (int i = 1; i <= n; i++)
            {
                numerator = Math.Pow(x, i);
                denominator += i;
                rs += numerator / denominator;
            }

            Console.WriteLine($"Bài số 16: Kết quả là {rs}");
        }

        private static void ProblemTwo(int n, int x)
        {
            if (n < 0)
            {
                Console.WriteLine("Bài số 17: Input n phải >= 0");
                return;
            }

            double rs        = 0;
            double numerator = 0;
            for (int i = 1; i <= n; i++)
            {
                numerator       = Math.Pow(x, 2 * i);
                int denominator = Support.factorialCal(2 * i);
                rs += numerator / denominator;
            }

            Console.WriteLine($"Bài số 17: Kết quả là {rs}");
        }

        private static void ProblemThree(int n, int x)
        {
            double numerator;
            double dominator;
            double rs = 1;
            for (int i = 0; i <= n; i++)
            {
                numerator = Math.Pow(x, 2 * i);
                dominator = Support.factorialCal(2 * i);
                rs += numerator / dominator;
            }

            Console.WriteLine($"Bài số 18: Kết quả là {rs}");
        }
    }
}