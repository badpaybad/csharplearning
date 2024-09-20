namespace ChungnbAbstractClass.Support;

class SupportDisplay
{
    public static void Display(object value, string message = "Kết quả là")
    {
        Console.WriteLine($"{message}: {value}");
    }

    public static void DisplayBool(bool isTrue, string message = "tồn tại giá trị")
    {
        string confirmation = isTrue ? "Có" : "Không";
        Console.WriteLine($"{confirmation} {message}");
    }
    
    public static void DisplayArrayDouble(double[] value, string message = "Mảng các số thực")
    {
        Console.WriteLine($"{message}: [{string.Join(" ", value)}]");
    }
    
    public static void DisplayArrayInt(int[] value, string message = "Mảng các số nguyên")
    {
        Console.WriteLine($"{message}: [{string.Join(" ", value)}]");
    }
}
