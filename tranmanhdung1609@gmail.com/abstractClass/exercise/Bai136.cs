namespace abclass.exercise
{
    public class Bai136 : AbstractClass
    {
        public override void Run()
        {
            int[] array = ArrayInt.InputArray();

            int maxValue = FindLastEven(array);

            Console.WriteLine("So chan cuoi cung " + maxValue);
        }

        private int FindLastEven(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
