namespace abstractClass
{
    public class BaiTap136 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 1, 3, 5, 6, 7, 8 };
            int lastEven = Bai136Function(array);
            Console.WriteLine("Số chẵn cuối cùng là: " + lastEven);
        }

        private int Bai136Function(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
