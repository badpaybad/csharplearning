namespace abclass.exercise
{
    public class Bai140 : AbstractClass
    {
        private double FindSmallestPositive(double[] array)
        {
            double minPositive = double.MaxValue;
            bool hasPositive = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    hasPositive = true;
                    if (array[i] < minPositive)
                    {
                        minPositive = array[i];
                    }
                }
            }

            return hasPositive ? minPositive : -1;
        }


        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double minPositive = FindSmallestPositive(array);

            if (minPositive == -1)
            {
                Console.WriteLine("Khong co gia tri duong trong mang.");
            }
            else
            {
                Console.WriteLine("Gia tri duong nho nhat trong mang la: " + minPositive);
            }
        }
    }
}
