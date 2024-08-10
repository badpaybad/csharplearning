using System;

public class Class1
{
    static void Main()
    {

        //exercise 1
        Console.WriteLine("Exercise 1 result:");
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(exercise1(n));

        //exercise 2
        Console.WriteLine("Exercise 2 result:");
        Console.WriteLine(exercise2(n));

        //exercise 3
        Console.WriteLine("Exercise 3 result:");
        Console.WriteLine(exercise3(n));

        //exercise 4
        Console.WriteLine("Exercise 4 result:");
        Console.WriteLine(exercise4(n));

        //exercise 5
        Console.WriteLine("Exercise 5 result:");
        Console.WriteLine(exercise5(n));

        //exercise 6
        Console.WriteLine("Exercise 6 result:");
        Console.WriteLine(exercise6(n));

        //exercise 7
        Console.WriteLine("Exercise 7 result:");
        Console.WriteLine(exercise7(n));

        //exercise 8
        Console.WriteLine("Exercise 8 result:");
        Console.WriteLine(exercise8(n));

        //exercise 9
        Console.WriteLine("Exercise 9 result:");
        Console.WriteLine(exercise9(n));

        //exercise 10
        Console.WriteLine("Exercise 10 result:");
        Console.Write("Enter a: ");
        int a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.Write(exercise10(a, b));

    }

    //exercise 1
    static int exercise1(int n)
    {
        int total = 0;
        for (int i = 0; i <= n; i++)
        {
            total += i;
        }

        return total;
    }

    //exercise 2:
    static double exercise2(int n)
    {
        double total = 0;
        for (int i = 0; i <= n; i++)
        {
            total += Math.Pow(i, 2);
        }
        return total;
    }

    //exercise 3:
    static double exercise3(int n)
    {
        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += (1.0 / i);
        }

        return total;
    }

    //exercise 4: 
    static double exercise4(int n)
    {
        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += (1.0 / (2 * i));
        }

        return total;
    }

    //exercise 5: 
    static double exercise5(int n)
    {
        double total = 0;
        for (int i = 0; i <= n; i++)
        {
            total += (1.0 / ((2 * i) + 1));
        }

        return total;
    }
    //exercise 6:

    static double exercise6(int n)
    {
        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += 1.0 / (i * (i + 1));
        }

        return total;
    }

    //exercise 7
    static double exercise7(int n)
    {
        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += (double)i / (i + 1);
        }

        return total;
    }

    //exercise 8
    static double exercise8(int n)
    {
        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += (double)(i * 2 + 1) / (2 * i + 2);
        }

        return total;
    }

    //exercise 9
    static double exercise9(int n)
    {
        double total = 1;
        for (int i = 1; i <= n; i++)
        {
            total *= i;
        }

        return total;
    }

    //exercise 10
    static double exercise10(int a, int b)
    {
        double total = Math.Pow((double)a, b);

        return total;
    }
}
