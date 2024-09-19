namespace abclass.exercise
{
    public class Bai134 : AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxValue = FindMax(array);

            Console.WriteLine("Gia tri lon nhat: " + maxValue);
        }

        private double FindMax(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
