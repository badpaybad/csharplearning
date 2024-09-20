using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace abclass.exercise
{
    public class Bai161: AbstractClass
    {
        private int FindFirstInRange(int[] array, int x, int y)
        {
            foreach (int value in array)
            {
                if (value > x && value < y)
                {
                    return value;
                }
            }
            return x;
        }

        private (int x, int y) InputRange()
        {
            Console.WriteLine("Gia tri x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Gia tri y:");
            int y = int.Parse(Console.ReadLine());

            return (x, y);
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            var range = InputRange();

            int result = FindFirstInRange(array, range.x, range.y);

            Console.WriteLine($"Giá trị đầu tiên trong mảng nằm trong khoảng ({range.x}, {range.y}) là: {result}");
        }
    }
}
