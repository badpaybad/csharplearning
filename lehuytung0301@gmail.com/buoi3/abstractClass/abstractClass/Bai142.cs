namespace abstractClass
{
    public class BaiTap142 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 3, 7, -9, 4, -5 };
            double minValue = Bai142Function(array);
            Console.WriteLine("Giá trị nhỏ nhất là: " + minValue);
        }

        private double Bai142Function(double[] array)
        {
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
