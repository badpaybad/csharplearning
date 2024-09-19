
namespace abclass.exercise
{
    public class Bai159 : AbstractClass
    {
        private double FindFirstGreaterThan2003(double[] array)
        {
            foreach (double value in array)
            {
                if (value > 2003)
                {
                    return value;
                }
            }
            return 0;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double result = FindFirstGreaterThan2003(array);

            Console.WriteLine($"Gia tri dau tien lon hon 2003 trong mang la: {result}");
        }
    }
}
