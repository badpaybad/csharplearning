using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    public class ArrayInt
    {
        public static int[] InputArray()
        {
            Console.WriteLine("So phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu{i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }
    }
}
