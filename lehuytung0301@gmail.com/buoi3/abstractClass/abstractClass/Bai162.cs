namespace abstractClass
{
    public class BaiTap162 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 2, 6, 12, 36, 18 };
            int result = Bai162Function(array);
            Console.WriteLine("Vị trí thỏa điều kiện là: " + result);
        }

        private int Bai162Function(double[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] == array[i - 1] * array[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
