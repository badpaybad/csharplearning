using System;

public class Program
{
    static void Main(string[] args)
    {
        //bai1 
        int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        //bai2 
        int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        //bai3
        double Sum(int n)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            return sum;

            }

