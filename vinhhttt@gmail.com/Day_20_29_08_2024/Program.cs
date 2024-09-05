using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Dem so luong so nguyen to nho hon 100 trong mang.");
        Console.WriteLine("2. Tinh tong cac gia tri am trong mang mot chieu cac so thuc.");
        Console.WriteLine("3. Sap xep mang mot chieu cac so thuc tang dan.");
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
                int primeCount = CountPrimesLessThan100(intArray);
                Console.WriteLine("So luong so nguyen to nho hon 100 trong mang la: " + primeCount);
                break;

            case 2:
                double[] doubleArray1 = InputDoubleArray();
                double sumNegatives = SumNegativeValues(doubleArray1);
                Console.WriteLine("Tong cac gia tri am trong mang la: " + sumNegatives);
                break;

            case 3:
                double[] doubleArray2 = InputDoubleArray();
                SortArrayAscending(doubleArray2);
                Console.WriteLine("Mang sau khi sap xep tang dan: ");
                PrintArray(doubleArray2);
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

    static int CountPrimesLessThan100(int[] array)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (IsPrime(num) && num < 100)
            {
                count++;
            }
        }
        return count;
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static double SumNegativeValues(double[] array)
    {
        double sum = 0;
        foreach (double num in array)
        {
            if (num < 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    static void SortArrayAscending(double[] array)
    {
        Array.Sort(array);
    }

    static void PrintArray(double[] array)
    {
        foreach (double num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
