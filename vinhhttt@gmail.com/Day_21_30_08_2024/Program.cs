using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Nhap mang mot chieu cac so thuc.");
        Console.WriteLine("2. Nhap mang mot chieu cac so nguyen.");
        Console.WriteLine("3. Xuat mang mot chieu cac so thuc.");
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
                Console.WriteLine("Mang so thuc da nhap thanh cong.");
                break;

            case 2:
                int[] intArray = InputIntArray();
                Console.WriteLine("Mang so nguyen da nhap thanh cong.");
                break;

            case 3:
                double[] doubleArrayToPrint = InputDoubleArray(); // Hoac su dung mang co san
                PrintDoubleArray(doubleArrayToPrint);
                break;
        }
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


    static void PrintDoubleArray(double[] array)
    {
        Console.WriteLine("Cac phan tu trong mang la:");
        foreach (double num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }


}
