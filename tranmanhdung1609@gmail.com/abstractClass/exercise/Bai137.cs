namespace abclass.exercise
{
    public class Bai137 : AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double minValue = FindPositionOfMin(array);

            Console.WriteLine("vi tri: " + minValue);
        }

        private double FindPositionOfMin(double[] array)
        {
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
