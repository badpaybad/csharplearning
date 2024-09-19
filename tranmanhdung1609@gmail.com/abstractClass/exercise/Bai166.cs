namespace abclass.exercise
{
    public class Bai166:AbstractClass
    {
        private bool IsPowerOfTwo(int num)
        {
            return num > 0 && (num & (num - 1)) == 0;
        }

        public int FindFirstPowerOfTwo(int[] array)
        {
            foreach (int num in array)
            {
                if (IsPowerOfTwo(num))
                {
                    return num;
                }
            }
            return 0;
        }

        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int result = FindFirstPowerOfTwo(array);
            Console.WriteLine($"Gia tri dau tien co dang 2^k la: {result}");
        }
    }
}
