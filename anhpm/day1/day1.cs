using System;
namespace day1
{
    public class Class1
    {
        static void Main(string[] args)
        {

            int tu = sumFractionExpow(2, 3)[0];
            int mau = sumFractionExpow(2, 3)[1];

            Console.WriteLine($": {tu}/{mau}");
        }
        //bai1
        static int sum(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return n + sum(n - 1);
        }
        //bai2
        static int expotential(int s, int n)
        {
            int flag = s;
            while (n > 1)
            {
                n = n - 1;
                flag = flag * s;
            }
            return flag;
        }
        static int sumExpow(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int exN = expotential(n, 2);
            return exN + sumExpow(n - 1);
        }

        //bai3
        static int[] sumFrN(int n)
        {
            if (n == 0) { int[] z = { 0, 1 }; return z; };
            if (n == 1) { int[] z = { 1, 1 }; return z; };
            int[] exN = { 1, n };
            return sumaryFraction(sumFraction(exN, sumFrN(n - 1)));
        }

        static int[] sumFraction(int[] ps1, int[] ps2)
        {
            int tu = ps1[1] * ps2[0] + ps1[0] * ps2[1];
            int mau = ps1[1] * ps2[1];
            int[] ps = { tu, mau };
            return sumaryFraction(ps);
        }
        static int[] sumaryFraction(int[] ps)
        {

            int n;
            if (ps[0] >= ps[1])
            {
                n = ps[1];
            }
            else
            {
                n = ps[0];
            }
            int z = 0;
            for (int i = 1; i <= n; i++)
            {
                if (ps[1] % i == 0 && ps[0] % i == 0)
                {
                    z = i;
                }
            }
            int[] psEnd = { ps[0] / z, ps[1] / z };
            return psEnd;
        }
        //bai16

        static int[] sumFractionExpow(int x, int n)
        {
            if (n == 0) { int[] z = { 0, 1 }; return z; };
            if (n == 1) { int[] z = { x, 1 }; return z; };
            int[] ps = { expotential(x, n), sum(n) };
            Console.WriteLine($"{ps[0]} {ps[1]}");
            return sumFraction(ps, sumFractionExpow(x, n - 1));
        }
        //bai 12

        static int sum12(int x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            return expotential(x, n) + sum12(x, n - 1);
        }
        //bai 19
        static float sum19(int x, int n)
        {
            if (n == 1) return expotential(x, 3) /multiplication(3);
            if (n == 0) return x;
            k = 2 * n + 1;
            return expotential(x, k) / multiplication(k) + sum19(x,n-1);
        }
        static float multiplication( int n)
        {
            if (n == 1) return 1;
            return n * multiplication(n - 1);
        }
    }
}
