namespace abstractClass
{
    public class BaiTap155 : BaiTap
    {
        public override void Run()
        {
            double[] array = { 24, 45, 23, 13, 43 };
            double x = 15;
            double xaNhat = Bai155Function(array, x);
            Console.WriteLine("Giá trị xa nhất với " + x + " là: " + xaNhat);
        }

        private double Bai155Function(double[] array, double x)
        {
            double maxDistance = Math.Abs(array[0] - x);
            double xaNhat = array[0];
            foreach (double value in array)
            {
                double distance = Math.Abs(value - x);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    xaNhat = value;
                }
            }
            return xaNhat;
        }
    }
}
