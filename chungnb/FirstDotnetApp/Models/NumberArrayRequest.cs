namespace TinhToan.Models
{
    public class NumberArrayRequest
    {
        public int[] Numbers { get; set; } = Array.Empty<int>();
    }

    public class NumberArrayWithXRequest
    {
        public int[] Numbers { get; set; } = Array.Empty<int>();
        public double X { get; set; }
    }
}