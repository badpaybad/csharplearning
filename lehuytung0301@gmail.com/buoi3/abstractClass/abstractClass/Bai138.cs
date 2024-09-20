namespace abstractClass
{
    public class BaiTap138 : BaiTap
    {
        public override void Run()
        {
            int[] array = { 1, 3, 5, 4, 7 };
            int firstEvenIndex = Bai138Function(array);
            Console.WriteLine("Vị trí giá trị chẵn đầu tiên là: " + firstEvenIndex);
        }

        private int Bai138Function(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
