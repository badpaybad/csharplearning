
class Program
{
    static void Main()
    {
        Console.WriteLine("Chon chuc nang can thuc hien:");
        Console.WriteLine("1. Tim vi tri co gia tri nho nhat trong mang mot chieu so thuc.");
        Console.WriteLine("2. Tim vi tri cua gia tri chan dau tien trong mang mot chieu so nguyen.");
        Console.WriteLine("3. Tim vi tri so hoan thien cuoi cung trong mang mot chieu so nguyen.");
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
                int minIndex = FindMinValuePosition(doubleArray);
                Console.WriteLine("Vi tri co gia tri nho nhat trong mang la: " + minIndex);
                break;

            case 2:
                int[] intArray = InputIntArray();
                int firstEvenIndex = FindFirstEvenPosition(intArray);
                if (firstEvenIndex == -1)
                {
                    Console.WriteLine("Mang khong co gia tri chan.");
                }
                else
                {
                    Console.WriteLine("Vi tri cua gia tri chan dau tien trong mang la: " + firstEvenIndex);
                }
                break;

            case 3:
                int[] intArrayForPerfect = InputIntArray();
                int lastPerfectIndex = FindLastPerfectNumberPosition(intArrayForPerfect);
                if (lastPerfectIndex == -1)
                {
                    Console.WriteLine("Mang khong co so hoan thien.");
                }
                else
                {
                    Console.WriteLine("Vi tri cua so hoan thien cuoi cung trong mang la: " + lastPerfectIndex);
                }
                break;
        }
    }

    // ham chung nhap phan tu array

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

    //139 

    static int FindLastPerfectNumberPosition(int[] array)
    {
        int lastIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (IsPerfectNumber(array[i]))
            {
                lastIndex = i;
            }
        }

        return lastIndex;
    }

    static bool IsPerfectNumber(int num)
    {
        if (num < 1) return false;

        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        return sum == num;
    }

    //138

    static int FindFirstEvenPosition(int[] array)
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


    // 137
    static int FindMinValuePosition(double[] array)
    {
        if (array.Length == 0) return -1;

        int minIndex = 0;
        double minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        return minIndex;
    }




}
