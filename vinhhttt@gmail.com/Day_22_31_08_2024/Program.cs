using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Xuat mang mot chieu cac so nguyen.");
        Console.WriteLine("2. Liet ke cac gia tri chan trong mang mot chieu cac so nguyen.");
        Console.WriteLine("3. Liet ke cac vi tri co gia tri am trong mang mot chieu cac so thuc.");
        Console.Write("Nhap lua chon cua ban (1/2/3): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Lua chon khong hop le. Vui long nhap lai (1/2/3): ");
        }

        switch (choice)
        {
            case 1:
                int[] intArray = InputIntArray(); 
                PrintIntArray(intArray);
                break;

            case 2:
                int[] intArrayForEven = InputIntArray();
                ListEvenValues(intArrayForEven);
                break;

            case 3:
                double[] doubleArray = InputDoubleArray();
                ListNegativeValuePositions(doubleArray);
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


    static void PrintIntArray(int[] array)
    {
        Console.WriteLine("Cac phan tu trong mang so nguyen la:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }


    static void ListEvenValues(int[] array)
    {
        Console.WriteLine("Cac gia tri chan trong mang la:");
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }


  static void ListNegativeValuePositions(double[] array)
{
    Console.WriteLine("Cac vi tri co gia tri am trong mang la:");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            Console.Write($"[{i}] ");
        }
    }
    Console.WriteLine();
}

}
