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
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            return sum;

            }
        //bai4 
        double Sum(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (2 * i);
            }
            return sum;
        }
        //bai5
        double Sum(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += 1 / (2 * i + 1);
            }
            return sum;
        }
        //bai6
        static double (int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (i * (i + 1));
            }
            return sum;
        }
        //bai7
        static double Sum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i / (i + 1);
            }
            return sum;
        }
        //bai8
        static double Sum(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += ((2 * i) + 1) / ((2 * i) + 2);
            }
            return sum;
        }
        //bai9
        static long Sum(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        //bai10
        static long bai10(int x, int n)
        {
            double result = Math.Pow(x, n);

            return (long)result;
        }
        //bai11
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
        //bai12
        static long bai12(int x, int n)
        {
            long sum = 0;
            long term = x; 

            for (int i = 1; i <= n; i++)
            {
                sum += term;      
                term *= x;        
            }

            return sum;         
        }
        //bai13
        static double Bai13(int n)
        {
            double sum = 0;
            for (in  i = 1; int <= n; i++)
            {
                sum += Math.Pow(2, 2 * i);
            }
        }
        //bai14
        static double Bai14(int n)
        {
            double sum = 0;
            for (in  i = 0; int <= n; i++)
            {
                sum += Math.Pow(2, ((2 * i) + 1));
            }
        }
        //bai15
        static double Bai15(int n)
        {
            double sum = 0
        for (int i = 1; i <= n; i++)
            {
                double innerSum = 0;
                for (int j = 1; j <= i; j++)
                {
                    innerSum += j;
                }
                sum += 1 / innerSum;
            }

            sum += 1;
            return sum;
        }
        //bai16
        static long Bai16(int n, int x)
        {
            double sum = x;

            for (int i = 2; i <= n; i++)
            {
                double innerSum = 0;
                for (int j = 1; j <= i; j++)
                {
                    innerSum += j;
                }
                sum += Math.Pow(x, i) / innerSum;
            }
            return sum;
        }
        //bai17
        static double bai17(int x, int n)
        {
            double sum = 0;
            double term = x;     
            long factorial = 1;  

            for (int i = 1; i <= n; i++)
            {
                if (i > 1)
                {
                    term *= x;       
                    factorial *= i;   
                }
                sum += term / factorial; 
            }

            return sum;
        }
        //bai18
        static double bai18(int x, int n)
        {
            double sum = 1;
            double term = 1;      
            long factorial = 1;

            for (int i = 1; i <= n; i++)
                {
                    term *= x * x;     
                    factorial *= (2 * i - 1) * (2 * i); 
                    sum += term / factorial; 
                }

                return sum;
            }
        //bai19 
        static double bai19(int x, int n)
        {
            double sum = 1;      
            double term = 1;      
            long factorial = 1;    

            for (int i = 1; i <= n; i++)
            {
                term *= x * x * x;       
                factorial *= (2 * i) * (2 * i + 1);
                sum += term / factorial; 
            }

            return sum;
        }
        //bai20
        static List<int> bai20(int n)
        {
            List<int> xxx = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)  
                {
                    xxx.Add(i);
                }
            }

            return xxx;
        }
        //bai21
        static int bai21(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

