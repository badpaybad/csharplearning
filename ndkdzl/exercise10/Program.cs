using System;
using System.Collections;

public class Class1
{
    static void Main()
    {

        //exercise 1
        Console.WriteLine("Exercise 130 result:");
        exercise130();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 131 result:");
        exercise131();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 132 result:");
        exercise132();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 133 result:");
        exercise133();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 134 result:");
        double[] arrayExercise134 = { 5, 2, 3, 3.5, 2.1, 9.6, 3.5,10.0,6.5 };
        Console.WriteLine(exercise134(arrayExercise134));
        Console.WriteLine("Exercise 135 result:");
        double[] arrayExercise135 = { -5, 2, 3, 3.5, 2.1, 9.6, 3.5, 10.0, 6.5 };
        Console.WriteLine(exercise135(arrayExercise135));

        Console.ReadLine();
    }

    static void exercise130()
    {
        //Viết hàm xuất mảng một chiều các số thực.
        List<double> myArray = new List<double>([1.5,2.5,1.2,5,252.32]);
        foreach (double item in myArray)
        {
            Console.WriteLine("Value: " + item);
        }
    }

    static void exercise131()
    {
        //Viết hàm xuất mảng một chiều các số nguyên
        List<int> myArray = new List<int>([2, 3, 2, 5, 252, 32]);
        foreach (int item in myArray)
        {
            Console.WriteLine("Value: " + item);
        }
    }

    static void exercise132()
    {
        //Viết hàm liệt kê các giá trị chẵn trong mảng một chiều các số nguyên
        List<int> myArray = new List<int>([2, 3, 2, 5, 252, 32]);
        foreach (int item in myArray)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine("Value: " + item);
            }
        }
    }

    static void exercise133()
    {
        
        List<double> myArray = new List<double>([2.52, -3.1, 2.5, -5, 252, 32]);
        int count = 0;
        foreach (int item in myArray)
        {
            if (item < 0)
            {
                Console.WriteLine("Vi tri phan tu co gia tri la so am: " + count);
            }
            count++;

        }
    }

    static double exercise134(double[] array)
    {
        if(array.Length < 1)
        {
            return 0;
        }

        double max = array[0];

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static double exercise135(double[] array)
    {
        if (array.Length < 1) return -1;
        if (array[0] < 0) return -1;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) return array[i];
        }

        return -1;
    }
}
