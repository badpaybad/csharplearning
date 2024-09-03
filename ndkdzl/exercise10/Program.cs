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

}
