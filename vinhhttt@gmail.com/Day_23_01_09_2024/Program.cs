
class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Tim gia tri lon nhat trong mang mot chieu so thuc.");
        Console.WriteLine("2. Tim gia tri duong dau tien trong mang mot chieu so thuc.");
        Console.WriteLine("3. Tim so chan cuoi cung trong mang mot chieu so nguyen.");
        Console.Write("Nhap lua chon cua ban (1/2/3): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Lua chon khong hop le. Vui long nhap lai (1/2/3): ");
        }

        switch (choice)
        {
            case 1:
                double[] doubleArray = InputDoubleArray();
                double maxValue = FindMaxValue(doubleArray);
                Console.WriteLine("Gia tri lon nhat trong mang la: " + maxValue);
                break;

            case 2:
                double[] doubleArrayForPositive = InputDoubleArray();
                double firstPositive = FindFirstPositiveValue(doubleArrayForPositive);
                if (firstPositive == -1)
                {
                    Console.WriteLine("Mang khong co gia tri duong.");
                }
                else
                {
                    Console.WriteLine("Gia tri duong dau tien trong mang la: " + firstPositive);
                }
                break;

            case 3:
                int[] intArray = InputIntArray();
                int lastEven = FindLastEvenValue(intArray);
                if (lastEven == -1)
                {
                    Console.WriteLine("Mang khong co gia tri chan.");
                }
                else
                {
                    Console.WriteLine("So chan cuoi cung trong mang la: " + lastEven);
                }
                break;
        }
    }

    static int[] InputIntArray()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong cho so luong phan tu: ");
        }

        int[] array = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array[{i}] = ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Vui long nhap mot so nguyen hop le: ");
            }
            array[i] = value;
        }
        return array;
    }
    static double[] InputDoubleArray()
    {
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap mot so nguyen duong cho so luong phan tu: ");
        }

        double[] array = new double[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array[{i}] = ");
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Vui long nhap mot so thuc hop le: ");
            }
            array[i] = value;
        }
        return array;
    }

    static double FindMaxValue(double[] array)
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
    static double FindFirstPositiveValue(double[] array)
    {
        foreach (double num in array)
        {
            if (num > 0)
            {
                return num;
            }
        }
        return -1;
    }

    static int FindLastEvenValue(int[] array)
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
