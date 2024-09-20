namespace abstractClass
{
    public class BaiTap134 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 3, 7, 9, 4, 5 };
            double max = Bai134Function(array);
            Console.WriteLine("Giá trị lớn nhất là: " + max);
        }

        private double Bai134Function(double[] array)
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
