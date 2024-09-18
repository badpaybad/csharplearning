using System;

namespace Day_1
{
    public class InputDoubleArray
    {
        public static double[] GetDoubleArray()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Vui long nhap mot so nguyen duong cho so luong phan tu: ");
            }

            double[] array = new double[n];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"array[{i}] = ");
                double value;
                while (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Vui long nhap mot so thuc hop le: ");
                }
                array[i] = value;
            }
            return array;
        }
    }
}

