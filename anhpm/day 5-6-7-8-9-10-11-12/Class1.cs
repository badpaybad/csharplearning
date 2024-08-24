using System;

public class Class1
{
	public Class1()
	{
        //bai33
        public static float bai33(int n)
        {
            if (n == 1) return Math.Pow(2, 1.0 / 2);
            return Math.Pow(2 + Math.Pow(2, 1.0 / 2), 1.0 / 2);
        }
        //bai34
        public static float bai34(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Math.Pow(n + Math.Pow(n - 1, 1.0 / 2), 1.0 / 2);
        }
        //bai35
        public static float bai35(int x = 1, int n)
        {
            if (x == n) return Math.Pow(n, 1.0 / 2);
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Math.Pow(x + Math.Pow(x + 1, 1.0 / 2), 1.0 / 2);
        }
        //bai36
        public static float bai36(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return (float)(Math.Pow(luythua(n) + bai39(n - 1), 1.0 / 2));
        }
        //bai37
        public static float bai37(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return (float)(Math.Pow(n + bai39(n - 1), 1.0 / n));
        }
        //bai38
        public static float bai37(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            return (float)(Math.Pow(n + bai39(n - 1), 1.0 / (n + 1)));
        }
    }
}
