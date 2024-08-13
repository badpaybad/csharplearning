using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double result = Bai1(n);
            Console.WriteLine(result);
        }

        int Bai1(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        double Bai2(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        double Bai3(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;

            }
        }

        double Bai4(int n)
        {
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += 1 / (2 * i);
            }
            return S;
        }

        double Bai5(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += 1 / (2 * i + 1);
            }
            return sum;
        }

        static double Bai6(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (i * (i + 1));
            }
            return sum;
        }

        static double Bai7(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i / (i + 1);
            }
            return sum;
        }

        static double Bai8(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += ((2 * i) + 1) / ((2 * i) + 2);
            }
            return sum;
        }

        static long Bai9(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static long Bai10(int x, int n)
        {
            double result = Math.Pow(x, n);

            return result;
        }

        static long Bai11(int n)
        {
            long sum = 0;
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }

            return sum;
        }

        static long Bai12(int n, int x)
        {
            long sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i);
            }

            return sum;
        }
    }
}

