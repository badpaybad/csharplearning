namespace abstractClass
{
    public class BaiTap156 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 24, 27, 45, 23, 13, 43 };
            double x = 15;
            double ganNhat = Bai156Function(array, x);
            Console.WriteLine("Giá trị gần nhất với " + x + " là: " + ganNhat);
        }

        private double Bai156Function(double[] array, double x)
        {
            double minDistance = Math.Abs(array[0] - x);
            double ganNhat = array[0];
            foreach (double value in array)
            {
                double distance = Math.Abs(value - x);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    ganNhat = value;
                }
            }
            return ganNhat;
        }
    }
}
