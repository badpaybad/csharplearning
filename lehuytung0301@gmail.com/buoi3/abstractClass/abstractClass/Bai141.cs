namespace abstractClass
{
    public class BaiTap141 : BaiTap
    {
        public override void Run()
        {
            double[] array = { -3, 7, -9, 4, 5 };
            int minPositiveIndex = Bai141Function(array);
            Console.WriteLine("Vị trí giá trị dương nhỏ nhất là: " + minPositiveIndex);
        }

        private int Bai141Function(double[] array)
        {
            int minIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && (minIndex == -1 || array[i] < array[minIndex]))
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}
