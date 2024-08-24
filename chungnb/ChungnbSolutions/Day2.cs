using System;

namespace DayTwoNamespace
{
    class DayTwo
    {
        public static void Solutions()
        {
            int day = 2;
            int firstProblem = day * 3 - 2;
            Console.WriteLine($"-- Các bài từ {firstProblem} tới {firstProblem + 2} --");
            ProblemOne(1);
            ProblemTwo(1);
            ProblemThree(2);
        }

        private static void ProblemOne(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 4: Input phải >= 1");
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (2 * i);
            }
            Console.WriteLine($"Bài số 4: Kết quả là {sum}");
        }

        private static void ProblemTwo(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 5: Input phải >= 1");
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += 1.0 / (2 * i + 1);
            }
            Console.WriteLine($"Bài số 5: Kết quả là {sum}");
        }

        private static void ProblemThree(int n)
        {
            if (n <= 0) {
                Console.WriteLine("Bài số 6: Input phải >= 1");
                return;
            }

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * (i + 1));
            }

            Console.WriteLine($"Bài số 6: Kết quả là {sum}");
        }
    }
}