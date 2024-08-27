using System;

public class SessionOne
{
    public SessionOne()
    {

    }
    public static int bai1(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return n + bai1(n - 1);
    }

    public static int bai2(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return (int)Math.Pow(n, 2) + bai2(n - 1);
    }

    public static float bai3(int n)
    {
        try
        {
            if (n == 0) throw new Exception("bai 3 value n=0 is invalid ");
            if (n == 1) return 1;
            return (float)(1f / n) + bai3(n - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            return 0;
        }
    }

    public static float bai4(int n)
    {
        try
        {
            if (n == 0) throw new Exception("bai 4 value n=0 is invalid ");
            if (n == 1) return 1f / 2;
            return (float)(1f / (2 * n)) + bai4(n - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            return 0;
        }
    }

    public static float bai5(int n)
    {
        try
        {
            if (n == 0) return 1;
            return (float)(1f / (2 * n + 1)) + bai5(n - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            return 0;
        }
    }

    public static float bai6(int n)
    {
        try
        {
            if (n == 0) throw new Exception("bai 6 value 0 is invalid");
            if (n == 1) return 1f / 2;
            return (float)1f / (n * (n + 1)) + bai6(n - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            return 0;
        }
    }

    public static float bai7(int n)
    {
        try
        {
            if (n == 0) return 0;
            if (n == 1) return 1f / 2;
            return (float)1f * n / (n + 1) + bai7(n - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            return 0;
        }
    }

    public static float bai8(int n)
    {
        try
        {
            if (n == 0) return 1f / 2;
            return (float)1f * (2 * n + 1) / (2 * n + 2) + bai8(n - 1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
            return 0;
        }
    }

    public static int bai9(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return n * bai9(n - 1);
    }

    public static double bai10(int n)
    {

        return Math.Pow(n, n);
    }

    public static int bai11(int n)
    {
        if (n == 1) return 1;
        if (n == 0) return 0;
        return bai9(n) + bai11(n - 1);
    }

    public static double bai12(int x, int n)
    {
        if (n == 1) return x;
        if (n == 0) return 1;
        return Math.Pow(x, n) + bai12(x, n - 1);
    }

    public static double bai13(int x, int n)
    {
        if (n == 1) return Math.Pow(x, 2);
        if (n == 0) return 1;
        return Math.Pow(x, n * 2) + bai13(x, n - 1);
    }

    public static double bai14(int x, int n)
    {
        if (n == 0) return x;
        return Math.Pow(x, n * 2+1) + bai14(x, n - 1);
    }

    public static float bai15( int n)
    {
        try
        {
            if(n == 1) return 1;
            if(n == 0)  throw new Exception("n = o is invalid");
            return (float) 1f / bai1(n) + bai15(n - 1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    public static float bai16(int x,int n)
    {
        try
        {
            if (n == 1) return x;
            if (n == 0) throw new Exception("n = o is invalid");
            return (float) (1f*Math.Pow(x,n) / bai1(n) + bai16(x,n - 1));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
}
