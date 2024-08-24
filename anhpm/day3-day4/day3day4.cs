using System;

public class Class1
{
    public Class1()
    {
        //bai39
        public static float bai39(int n)
        {
            if (n == 1) return (float)Math.Sqrt(1);

            return (float)(Math.Pow(luythua(n) + bai39(n - 1), 1.0 / (n + 1)));
        }
        public static int luythua(int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 1;
            return n * luythua(n - 1);
        }
        //bai40
        public static float bai40(int x, int n)
        {
            if (n == 1) return (float)Math.Sqrt(x);
            return (float)Math.Sqrt(Math.Pow(x, n) + bai40(x, n - 1));
        }
        //bai41
        public static float bai41(int n)
        {
            if (n == 1) return (float)(1 / 2);
            return (float)(1 / 1 + bai41(n - 1));
        }

        //bai42 
        public static int checkK(int n)
        {
            int i = 0;
            int s = 0;
            while (s < n)
            {
                s = s + i;
                i = i + 1;
            }
            if (i + s >= n && i != 0) return i - 1;
            return i;
        }
        //bai59 kiem tra so doi xung
        public static int[] intToArray(int n)
        {
            string nString = n.ToString();
            int[] arrayN = new int[nString.Length];
            for (int i = 0; i < nString.Length; i++)
            {
                arrayN[i] = int.Parse(nString[i].ToString());
            }
            return arrayN;
        }
        public static Boolean bai59(int[] arrayN)
        {
            if (arrayN.Length % 2 == 0) return checking(arrayN, arrayN.Length / 2 - 1, arrayN.Length / 2);
            return checking(arrayN, arrayN.Length / 2 - 1, arrayN.Length / 2 + 1);

        }
        public static Boolean checking(int[] arrayN, int x, int y)
        {
            if (!checkDoiXung(arrayN, x, y))
            {
                return false;
            }
            if (x == 0) return true;
            if (arrayN.Length == 0) return true;
            return checking(arrayN, x - 1, y + 1);

        }
        public static Boolean checkDoiXung(int[] arrayN, int x, int y)
        {
            Boolean check = arrayN[x] == arrayN[y];
            return check;
        }
        //bai62
        static int bai62(int a, int b)
        {
            if (b == 0) return a;
            return bai62(b, a % b);
        }

        //bai63
        static int bai63(int a, int b)
        {
            return (a * b) / bai63(a, b);
        }

       
    }
}
