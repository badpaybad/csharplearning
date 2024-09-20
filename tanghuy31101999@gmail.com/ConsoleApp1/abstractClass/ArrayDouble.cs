using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    public class ArrayDouble
    {
        public static double[] InputArray()
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            Console.WriteLine("Nhap phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            return array;
        }
    }
}
