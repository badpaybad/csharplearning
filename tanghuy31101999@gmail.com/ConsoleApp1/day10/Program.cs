using System;
using System.Reflection;
using System.Xml.Linq;

public class SessionOne { 

    static void Main(string[] args){
    double[] arrayDouble = { 1.5, 2.8, 3.1, 0.9, 9, 9.4, 9.3 };
    int[] arrayInt = { 12, 123, 2342, 123 };
    int itemInt = 112;
    double itemDouble = 1;


        Console.WriteLine($"bai tap 122: {bai122(arrayDouble)}");

        Console.WriteLine($"bai tap 123: {bai123(arrayInt)}");

        Console.WriteLine($"bai tap 124: {bai124(arrayInt)}");

        Console.WriteLine($"bai tap 125: {bai125(arrayInt)}");

        Console.WriteLine($"bai tap 126: {bai126(arrayDouble)}");

        Console.WriteLine($"bai tap 127: {bai127(arrayDouble)}");

        Console.WriteLine($"bai tap 128: {bai128(arrayDouble)}");

        Console.WriteLine($"bai tap 129: {bai129(arrayInt)}");

        Console.WriteLine($"bai tap 130: {bai130(arrayDouble)}");

        Console.WriteLine($"bai tap 131: {bai131(arrayInt)}");

        Console.WriteLine($"bai tap 132: {bai132(arrayInt)}");

        Console.WriteLine($"bai tap 133: {bai133(arrayDouble)}");

        Console.WriteLine($"bai tap 134: {bai134(arrayDouble)}");
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
        return x.Count(n => n < 100 && soNguyenTo(n));
    }


    public static bool soNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }
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


    public static double[] bai127(double[] x)
    {
      Array.Sort(x);
      return x;
    }

    public static double[] bai128(double[] x)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        double[] newArray = new double[x.Length + 1];

        for (int i = 0; i < x.Length; i++)
        {
            newArray[i] = x[i];
        }

        newArray[x.Length] = size;

        return newArray.ToArray();
       
    }


    public static int[] bai129(int[] x)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        int[] newArray = new int[x.Length + 1];

        for (int i = 0; i < x.Length; i++)
        {
            newArray[i] = x[i];
        }

        newArray[x.Length] = size;

        return newArray.ToArray();
    }


    public static double[] bai130(double[] x)
    {
        int index = Convert.ToInt32(Console.ReadLine());
        if (index < 0 || index >= x.Length)
        {
            return x; 
        }

        double[] newArray = new double[x.Length - 1];

        for (int i = 0, j = 0; i < x.Length; i++)
        {
            if (i != index)
            {
                newArray[j++] = x[i];
            }
        }

        return newArray.ToArray();

    }


    public static int[] bai131(int[] x)
    {
        int index = Convert.ToInt32(Console.ReadLine());
        if (index < 0 || index >= x.Length)
        {
            return x; 
        }

        int[] newArray = new int[x.Length - 1];

        for (int i = 0, j = 0; i < x.Length; i++)
        {
            if (i != index)
            {
                newArray[j++] = x[i];
            }
        }

        return newArray.ToArray();
    }


    public static int[] bai132(int[] x)
    {
        List<int> evenNumbers = new List<int>();

        foreach (int num in x)
        {
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }

        return evenNumbers.ToArray();
    }


    public static double[] bai133(double[] x)
    {
        List<double> negativeIndices = new List<double>();

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < 0)
            {
                negativeIndices.Add(i);
            }
        }

        return negativeIndices.ToArray();
    }


    public static double bai134(double[] x)
    {
        int length = x.Length;
        double max = 0.0;

        for (int i = 0; i < length; i++)
        {
            if (x[i] > max)
            {
                max = x[i];
            }
        }
        return max;
    }

    public static double bai135(double[] x)
    {
        int length = x.Length;
        double rs = -1;

        for (int i = 0; i < length; i++)
        {
            if (x[i] > 0)
            {
                rs = x[i];
                break;
            }
        }

        return rs;
    }


    public static int bai136(int[] x) { 

        int length = x.Length;
        int rs = 1;

        for (int i = 0; i < length; i++)
        {
            if (x[i] % 2 == 0)
            {
                rs = x[i];
            }
        }

        return rs;
    }

    public static int bai137(int[] x){
        int length = x.Length;
        double min = x[0];
        int position = 0;

        for (int i = 1; i < length; i++)
        {
            if (x[i] < min)
            {
                min = x[i];
                position = i;
            }
        }
        return position;
    }


    public static int bai138(int[] x)
    {
        int length = x.Length;
        int position = -1;

        for (int i = 0; i < length; i++)
        {
            if (x[i] % 2 == 0)
            {
                position = i;
                break;
            }
        }

        return position;
    }


    public static int bai139(int[] x)
    {
        int length = x.Length;
        int position = -1;

        for (int i = 0; i < length; i++)
        {
            if (x[i] % 2 == 0)
            {
                position = i;
            }
        }

        return position;
    }


    public static double bai140(double[] x)
    {
        int length = x.Length;
        double maxValue = double.MaxValue;
        double data = -1;

        for (int i = 0; i < length; i++)
        {
            if (x[i] > 0 && x[i] < maxValue)
            {
                data = x[i];
            }
        }

        return data;
    }


    public static double bai141(double[] x)
    {
        //int length = x.Length;
        //double maxValue = double.MaxValue;
        //int position = -1;

        //for (int i = 0; i < length; i++)
        //{
        //    if (x[i] > 0 && data < maxValue)
        //    {
        //        data = x[i];
        //        position = i;
        //    }
        //}

        //return data;
    }


}