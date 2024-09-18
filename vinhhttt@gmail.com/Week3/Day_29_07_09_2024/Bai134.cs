namespace Day_1.Day_29_07_09_2024
{
    public class Bai134 : Homework
    {
        public override void Run()
        {
            double[] doubleArray = InputDoubleArray.GetDoubleArray();
            double maxValue = FindMaxValue(doubleArray);
            Console.WriteLine("Gia tri lon nhat trong mang la: " + maxValue);
        }


        private static double FindMaxValue(double[] array)
        {
            if (array.Length == 0) return double.MinValue;

            double maxValue = array[0];
            foreach (double num in array)
            {
                if (num > maxValue)
                {
                    maxValue = num;
                }
            }

            return maxValue;
        }
    }
}