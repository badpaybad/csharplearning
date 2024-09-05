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
        return Math.Pow(x, n * 2 + 1) + bai14(x, n - 1);
    }

    public static float bai15(int n)
    {
        try
        {
            if (n == 1) return 1;
            if (n == 0) throw new Exception("n = o is invalid");
            return (float)1f / bai1(n) + bai15(n - 1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    public static float bai16(int x, int n)
    {
        try
        {
            if (n == 1) return x;
            if (n == 0) throw new Exception("n = o is invalid");
            return (float)(1f * Math.Pow(x, n) / bai1(n) + bai16(x, n - 1));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return 0;
        }
    }

    public static double bai122(double[] x)
    {
        if (x.Length <= 0) return -1;

        double f = x[0];

        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] > f) f = x[i];
        }
        return f;
    }

    public static int bai123(int[] x)
    {
        if (x.Length <= 0) return -1;

        int f = x[0];
        int k = 0;
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] < f)
            {
                f = x[i];
                k = i;
            };

        }
        return k;
    }

    public static Boolean bai124(int[] x)
    {
        if (x.Length <= 0) return false;


        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] < 2004 && x[i] % 2 == 0)
            {
                return true;    
            };

        }
        return false;
    }

    public static int bai125(int[] x)
    {
        return x.Count(n => n < 100 && IsPrime(n));
    }

   
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

 
    public static double bai126(double[] x)
    {
        return x.Where(n => n < 0).Sum();
    }

    
    public static void bai127(double[] x)
    {
        Array.Sort(x);
    }

  
    public static double[] bai128(int size)
    {
        double[] array = new double[size];
        for (int i = 0; i < size; i++)
        {
            
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        return array;
    }

   
    public static int[] bai129(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }

  
    public static void bai130(double[] x)
    {
        Array.ForEach(x, Console.WriteLine);
    }

  
    public static void bai131(int[] x)
    {
        Array.ForEach(x, Console.WriteLine);
    }

    
    public static void bai132(int[] x)
    {
        foreach (var n in x.Where(n => n % 2 == 0))
        {
            Console.WriteLine(n);
        }
    }

    
    public static void bai133(double[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < 0) Console.WriteLine($" {i}: {x[i]}");
        }
    }

   
    public static double bai134(double[] x)
    {
        if (x.Length == 0) return -1;

        double max = x[0];
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] > max) max = x[i];
        }
        return max;
    }

    
    public static double bai135(double[] x)
    {
        foreach (var value in x)
        {
            if (value > 0) return value;
        }
        return -1;
    }

    
    public static int bai136(int[] x)
    {
        for (int i = x.Length - 1; i >= 0; i--)
        {
            if (x[i] % 2 == 0) return x[i];
        }
        return -1;
    }

   
    public static int bai137(double[] x)
    {
        if (x.Length == 0) return -1;

        double min = x[0];
        int minIndex = 0;
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] < min)
            {
                min = x[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

   
    public static int bai138(int[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % 2 == 0) return i;
        }
        return -1;
    }

   
    public static int bai139(int[] x)
    {
        bool IsPerfect(int num)
        {
            if (num < 1) return false;
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) sum += i;
            }
            return sum == num;
        }

        for (int i = x.Length - 1; i >= 0; i--)
        {
            if (IsPerfect(x[i])) return i;
        }
        return -1;
    }

    
    public static double bai140(double[] x)
    {
        double minPositive = double.MaxValue;
        bool foundPositive = false;
        foreach (var value in x)
        {
            if (value > 0 && value < minPositive)
            {
                minPositive = value;
                foundPositive = true;
            }
        }
        return foundPositive ? minPositive : -1;
    }

    
    public static int bai141(double[] x)
    {
        double minPositive = double.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0 && x[i] < minPositive)
            {
                minPositive = x[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

   
    public static double bai142(double[] x)
    {
        if (x.Length == 0) return -1;

        double min = x[0];
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] < min) min = x[i];
        }
        return min;
    }

    
    public static int bai143(int[] x)
    {
        foreach (var value in x)
        {
            if (value % 2 == 0) return value;
        }
        return -1;
    }

    
    public static int bai144(int[] x)
    {
        bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        foreach (var value in x)
        {
            if (IsPrime(value)) return value;
        }
        return -1;
    }

   
    public static int bai145(int[] x)
    {
        bool IsPerfect(int num)
        {
            if (num < 1) return false;
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) sum += i;
            }
            return sum == num;
        }

        foreach (var value in x)
        {
            if (IsPerfect(value)) return value;
        }
        return -1;
    }

  
    public static double bai146(double[] x)
    {
        foreach (var value in x)
        {
            if (value < 0) return value;
        }
        return 1;
    }

    
    public static double bai147(double[] x)
    {
        for (int i = x.Length - 1; i >= 0; i--)
        {
            if (x[i] > 0) return x[i];
        }
        return -1;
    }

    
    public static int bai148(int[] x)
    {
        bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        for (int i = x.Length - 1; i >= 0; i--)
        {
            if (IsPrime(x[i])) return x[i];
        }
        return -1;
    }

    
    public static int bai149(int[] x)
    {
        bool IsPerfect(int num)
        {
            if (num < 1) return false;
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) sum += i;
            }
            return sum == num;
        }

        for (int i = x.Length - 1; i >= 0; i--)
        {
            if (IsPerfect(x[i])) return x[i];
        }
        return -1;
    }

    
    public static double bai150(double[] x)
    {
        double maxNegative = double.MinValue;
        bool foundNegative = false;
        foreach (var value in x)
        {
            if (value < 0 && value > maxNegative)
            {
                maxNegative = value;
                foundNegative = true;
            }
        }
        return foundNegative ? maxNegative : 0;
    }

    
    public static int bai151(int[] x)
    {
        bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        int maxPrime = 0;
        foreach (var value in x)
        {
            if (IsPrime(value) && value > maxPrime)
            {
                maxPrime = value;
            }
        }
        return maxPrime == 0 ? 0 : maxPrime;
    }

    
    public static int bai152(int[] x)
    {
        bool IsPerfect(int num)
        {
            if (num < 1) return false;
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0) sum += i;
            }
            return sum == num;
        }

        int minPerfect = int.MaxValue;
        foreach (var value in x)
        {
            if (IsPerfect(value) && value < minPerfect)
            {
                minPerfect = value;
            }
        }
        return minPerfect == int.MaxValue ? 0 : minPerfect;
    }

    
    public static int bai153(int[] x)
    {
        int minEven = int.MaxValue;
        foreach (var value in x)
        {
            if (value % 2 == 0 && value < minEven)
            {
                minEven = value;
            }
        }
        return minEven == int.MaxValue ? -1 : minEven;
    }


    public static int bai154(double[] x)
    {
        double maxNegative = double.MinValue;
        int index = -1;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < 0 && x[i] > maxNegative)
            {
                maxNegative = x[i];
                index = i;
            }
        }
        return index;
    }
}
