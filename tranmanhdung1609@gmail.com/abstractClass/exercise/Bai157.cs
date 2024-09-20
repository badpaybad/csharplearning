namespace abclass.exercise
{
    public class Bai157 : AbstractClass
    {
        private (double, double) FindRange(double[] array)
        {
            if (array.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            double minValue = array[0];
            double maxValue = array[0];

            foreach (double value in array)
            {
                if (value < minValue)
                {
                    minValue = value;
                }

                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return (minValue, maxValue);
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            var (minValue, maxValue) = FindRange(array);

            Console.WriteLine($"Doan [a, b] chua tat ca cac gia tri trong mang la: [{minValue}, {maxValue}]");
        }
    }
}
