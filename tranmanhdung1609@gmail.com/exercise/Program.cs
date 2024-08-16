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

        static double Bai13(int n)
        {
            double sum = 0;
            for(in  i = 1; int <= n; i++)
            {
                sum += Math.Pow(2, 2 * i);
            }
        }


        static double Bai14(int n)
        {
            double sum = 0;
            for (in  i = 0; int <= n; i++)
            {
                sum += Math.Pow(2, ((2 * i) + 1));
            }
        }


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
        
        static long Bai16(int n,int x)
        {
            double sum = x; // Khởi tạo sum với giá trị x (số hạng đầu tiên)

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

        static long GiaiThua(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static double Bai17(int n, double x)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i) / GiaiThua(i);
            }

            return sum;
        }


        static double Bai19(int n, double x)
        {
            double sum = 1;

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, (2* i)+1) / GiaiThua((2 * i) + 1);
            }

            return sum;
        }

        static double Bai18(int n, double x)
        {
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, 2 * i) / GiaiThua(2 * i);
            }

            return sum;
        }


        static int[] Bai20(int n)
        {
            List<int> uocSoList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    uocSoList.Add(i);
                }
            }

            return uocSoList.ToArray();
        }

        static int Bai21(int n)
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

        static long Bai22(int n)
        {
            long product = 1;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    product *= i;
                }
            }

            return product;
        }

        static long Bai23(int n)
        {
            long product = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    product++;
                }
            }

            return product;
        }

        static int[] bai24(int n)
        {
            List<int> array = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                    array.Add(i);
                }
            }

            return array;
        }

        static double bai25(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static double Bai26(int n)
        {
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                    sum *= i;
                }
            }
            return sum;
        }

        static double bai27(int n)
        {
            double soluong = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 == 0)
                {
                    soluong++
                }
            }

            return soluong;
        }

        static int Bai28(int n)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static int bai29(int n)
        {
            int largestOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                {
                    if (i > largestOdd)
                    {
                        largestOdd = i;
                    }
                }
            }

            return largestOdd;
        }

        static string Bai30(int n)
        {
    
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                return n + " là số hoàn thiện";
            }
            else
            {
                return n + " là số không hoàn thiện";
            }
        }

    }
}

