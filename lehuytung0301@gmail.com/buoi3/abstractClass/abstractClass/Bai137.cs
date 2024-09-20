namespace abstractClass
{
    public class BaiTap137 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 3, 7, -9, 4, -5 };
            int minIndex = Bai137Function(array);
            Console.WriteLine("Vị trí giá trị nhỏ nhất là: " + minIndex);
        }

        private int Bai137Function(double[] array)
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
