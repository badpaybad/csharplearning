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
}
