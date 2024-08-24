using System;

namespace DayThreeNamespace
{
    class DayThree
    {
        public static void Solutions()
        {
            int day = 3;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(2);
            ProblemTwo(1);
            ProblemThree(4);
        }

        private static void ProblemOne(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 7: Input phải >= 1");
                return;
            }

            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += i / (i + 1);
            }

            Console.WriteLine($"Bài số 7: Kết quả là {sum}");
        }

        private static void ProblemTwo(int n)
        {
            if (n < 0) {
                Console.WriteLine("Bài số 8: Input phải >= 0");
                return;
            }

            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                sum += (2 * i + 1) / (2 * i + 2);
            }

            Console.WriteLine($"Bài số 8: Kết quả là {sum}");
        }

        private static void ProblemThree(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 9: Input phải >= 1");
                return;
            }

            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            Console.WriteLine($"Bài số 9: Kết quả là {sum}");
        }
    }
}