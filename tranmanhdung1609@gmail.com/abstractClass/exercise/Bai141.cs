namespace abclass.exercise
{
    public class Bai141 : AbstractClass
    {
        private int FindPositionOfSmallestPositive(double[] array)
        {
            int position = -1;
            double minPositive = double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (array[i] < minPositive)
                    {
                        minPositive = array[i];
                        position = i;
                    }
                }
            }

            return position;
        }

        public override void Run()
        {
            double[] array = ArrayDouble.InputArray();

            double position = FindPositionOfSmallestPositive(array);

            if (position == -1)
            {
                Console.WriteLine("Khong co gia tri duong trong mang.");
            }
            else
            {
                Console.WriteLine("Vi tri cua gia tri duong nho nhat trong mang la: " + position);
            }
        }
    }
}
