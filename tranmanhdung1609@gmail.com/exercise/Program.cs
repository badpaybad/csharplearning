using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args) 
        {
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
        }
    }
}

