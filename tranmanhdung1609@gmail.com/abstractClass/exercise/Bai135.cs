namespace abclass.exercise
{
    public class Bai135 : AbstractClass
    {
        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double maxValue = FindFirstPositive(array);

            Console.WriteLine("Gia tri duong dau tien: " + maxValue);
        }

        private double FindFirstPositive(double[] array)
        {
            foreach (var value in array)
            {
                if (value > 0)
                {
                    return value;
                }
            }
            return -1;
        }
    }
}
