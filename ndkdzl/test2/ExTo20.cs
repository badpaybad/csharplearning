using System;
using System.Numerics;

namespace HelloWorld
{
    class Person
    {
        static void Main()
        {

            //exercise 11
            Console.Write("Enter a: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(exercise11(a, b));
            Console.ReadLine();
        }

        //exercise 1
        static int exercise11(int a, int b)
        {
            return (a+b);
        }
    }
}