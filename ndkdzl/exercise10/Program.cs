using System;
using System.Collections;
using System.Diagnostics;
using System.Xml.Xsl;

public class Class1: exerciseNeedUse
{
    static void Main()
    {
        Class1 obj = new Class1();
        //exercise 1
        Console.WriteLine("Exercise 130 result:");
        exercise130();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 131 result:");
        exercise131();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 132 result:");
        exercise132();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 133 result:");
        exercise133();
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 134 result:");
        double[] arrayExercise134 = { 5, 2, 3, 3.5, 2.1, 9.6, 3.5,10.0,6.5 };
        Console.WriteLine(exercise134(arrayExercise134));
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 135 result:");
        double[] arrayExercise135 = { -5, 2, 3, 3.5, 2.1, 9.6, 3.5, 10.0, 6.5 };
        Console.WriteLine(exercise135(arrayExercise135));
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 136 result:");
        int[] arrayExercise136 = { -5, 2, 3, 3, 2,6 };
        Console.WriteLine(exercise136(arrayExercise136));
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 137 result:");
        double[] arrayExercise137 = { -5, 2, 3, 3, 2, 6,-15 };
        Console.WriteLine(exercise137(arrayExercise137));
        Console.WriteLine("=======================================");
        Console.WriteLine("Exercise 138 result:");
        int[] arrayExercise138 = { -5, 3, 3, 3, 2, 6, -15 };
        Console.WriteLine(obj.exercise138(arrayExercise138));

        Console.WriteLine("Exercise 140 result:");
        double[] arrayExercise140 = { -5.2, 3.5, 3.1, 3.0, 2.2, 6.6, -15.5 };
        Console.WriteLine(exercise140(arrayExercise140));

        Console.WriteLine("Exercise 141 result:");
        double[] arrayExercise141 = { -5.2, 3.5, 3.1, 3.0, 2.2, 6.6, -15.5 };
        Console.WriteLine(exercise141(arrayExercise141));

        Console.WriteLine("Exercise 142 result:");
        double[] arrayExercise142 = { -5.2, 3.5, 3.1, -30.0, 2.2, 6.6, -15.5 };
        Console.WriteLine(exercise142(arrayExercise142));

        Console.WriteLine("Exercise 143 result:");
        int[] arrayExercise143 = { -5, 221, 3, -30, 22, 6, -1};
        Console.WriteLine(exercise143(arrayExercise143));

        Console.WriteLine("Exercise 144 result:");
        int[] arrayExercise144 = { -5, 11, 3, -30, 22, 6, -1 };
        Console.WriteLine(exercise144(arrayExercise144));

        Console.WriteLine("Exercise 145 result:");
        int[] arrayExercise145 = { -5, 11, 3, -30, 22, 6, -1 };
        Console.WriteLine(exercise145(arrayExercise145));

        Console.WriteLine("Exercise 146 result:");
        double[] arrayExercise146 = { 10,-6, 11, 3, -30, 22, 6, -1 };
        Console.WriteLine(exercise146(arrayExercise146));

        Console.WriteLine("Exercise 147 result:");
        double[] arrayExercise147 = { 10, -6, 11, 3, -30, 22, 1606, -1 };
        Console.WriteLine(exercise147(arrayExercise147));

        Console.WriteLine("Exercise 148 result:");
        int[] arrayExercise148 = { 10, -6, 11, 3, -30, 22, 11, -1 };
        Console.WriteLine(exercise148(arrayExercise148));

        Console.WriteLine("Exercise 150 result:");
        double[] arrayExercise150 = { 10, -6, 11, 3, -30, 22, 11, -10 };
        Console.WriteLine(exercise150(arrayExercise150));

        Console.WriteLine("Exercise 151 result:");
        int[] arrayExercise151 = { 10, -6, 11, 3, -30, 22, 11, -10 };
        Console.WriteLine(exercise151(arrayExercise151));

        Console.WriteLine("Exercise 152 result:");
        int[] arrayExercise152 = { 10, -6, 11, 6, -30, 22, 11, -10 };
        Console.WriteLine(exercise152(arrayExercise152));

        Console.WriteLine("Exercise 153 result:");
        int[] arrayExercise153 = { 10, -6, 11, 6, -30, 22, 11, -10 };
        Console.WriteLine(exercise153(arrayExercise153));

        Console.WriteLine("Exercise 154 result:");
        double[] arrayExercise154 = { 10, -6, 11, 6, -30, 22, 11, -10 };
        Console.WriteLine(exercise154(arrayExercise154));


        Console.ReadLine();
    }

    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static bool IsPerfectNumber(int number)
    {
        if (number <= 1) return false;

        int sum = Enumerable.Range(1, number / 2).Where(x => number % x == 0).Sum();

        return sum == number;
    }


    static void exercise130()
    {
        //Viết hàm xuất mảng một chiều các số thực.
        List<double> myArray = new List<double>([1.5,2.5,1.2,5,252.32]);
        foreach (double item in myArray)
        {
            Console.WriteLine("Value: " + item);
        }
    }

    static void exercise131()
    {
        //Viết hàm xuất mảng một chiều các số nguyên
        List<int> myArray = new List<int>([2, 3, 2, 5, 252, 32]);
        foreach (int item in myArray)
        {
            Console.WriteLine("Value: " + item);
        }
    }

    static void exercise132()
    {
        //Viết hàm liệt kê các giá trị chẵn trong mảng một chiều các số nguyên
        List<int> myArray = new List<int>([2, 3, 2, 5, 252, 32]);
        foreach (int item in myArray)
        {
            if (item % 2 == 0)
            {
                Console.WriteLine("Value: " + item);
            }
        }
    }

    static void exercise133()
    {
        
        List<double> myArray = new List<double>([2.52, -3.1, 2.5, -5, 252, 32]);
        int count = 0;
        foreach (int item in myArray)
        {
            if (item < 0)
            {
                Console.WriteLine("Vi tri phan tu co gia tri la so am: " + count);
            }
            count++;

        }
    }

    static double exercise134(double[] array)
    {
        if(array.Length < 1)
        {
            return 0;
        }

        double max = array[0];

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    static double exercise135(double[] array)
    {
        if (array.Length < 1) return -1;
        if (array[0] < 0) return -1;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) return array[i];
        }

        return -1;
    }

    static int exercise136(int[] array)
    {
        if (array.Length < 1) return -1;

        int result = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result = array[i];
            }
        }

        return result;
    }

    static double exercise137(double[] array)
    {
        if (array.Length < 1) return -1;

        double min = array[0];
        int count = 0;
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]  < min)
            {
                min = array[i];
                result = count;
            }
            count++;
        }

        return result;
    }

    public override int exercise138(int[] array)
    {
        // Tìm “vị trí của giá trị chẵn đầu tiên” trong mảng một chiều các số nguyên(vitrichandau).Nếu mảng không có giá trị chẵn thì hàm sẽ trả về giá trị là – 1
        if (array.Length < 1) return -1;

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                return count;
            }
            count++;
        }

        return -1;
    }

    //exercise 140
    static double exercise140(double[] numberDouble)
    {
        if (numberDouble.Length < 1)
        {
            return -1;
        }
        double min = numberDouble[0];
        foreach (double item in numberDouble)
        {
            if ((item < min && item > 0) || (min < 0 && item > 0))
            {
                min = item;
            }
        }

        if(min > 0)
        {
            return min;
        }
        return -1;
    }

    //exercise 141
    static int exercise141(double[] numberDouble)
    {
        if (numberDouble.Length < 1)
        {
            return -1;
        }
        double min = numberDouble[0];
        int count = 0;
        int indexMin = 0;
        foreach (double item in numberDouble)
        {
            if ((item < min && item > 0) || (min < 0 && item > 0))
            {
                min = item;
                indexMin = count;
            }
            count++;
        }

        if(min < 0)
        {
            return -1;
        }
        return indexMin;
    }

    //exercise 142
    static double exercise142(double[] numberDouble)
    {
        return numberDouble.Min();
    }

    //exercise 143
    static int exercise143(int[] numberIntArray)
    {

        int soChanDau = numberIntArray.FirstOrDefault(x => x % 2 == 0);

        soChanDau = soChanDau == 0 && !numberIntArray.Contains(0) ? -1 : soChanDau;

        return soChanDau;
    }

    //exercise 144
    static int exercise144(int[] numberInt)
    {
        int soNguyenTo = numberInt.FirstOrDefault(x => IsPrime(x));

        soNguyenTo = soNguyenTo == 0 ? -1 : soNguyenTo;

        return soNguyenTo;
    }

    //exercise 145
    static int exercise145(int[] numberInt)
    {

        int soHoanThien = numberInt.FirstOrDefault(x => IsPerfectNumber(x));

        soHoanThien = soHoanThien == 0 ? -1 : soHoanThien;

        return soHoanThien;
    }

    //exercise 146
    static double exercise146(double[] numberDouble)
    {
        double soAmDauTien = numberDouble.FirstOrDefault(x => x < 0);

        soAmDauTien = soAmDauTien == 0 ? 1 : soAmDauTien;

        return soAmDauTien;
    }

    //exercise 147
    static double exercise147(double[] numberDouble)
    {
        double soDuongCuoiCung = numberDouble.LastOrDefault(x => x > 0);

        soDuongCuoiCung = soDuongCuoiCung == 0 ? -1 : soDuongCuoiCung;

        return soDuongCuoiCung;
    }

    //exercise 148
    static int exercise148(int[] numberDouble)
    {

        int soNguyenToCuoiCung = numberDouble.LastOrDefault(x => IsPrime(x));

        soNguyenToCuoiCung = soNguyenToCuoiCung == 0 ? -1 : soNguyenToCuoiCung;

        return soNguyenToCuoiCung;
    }

    //exercise 150
    static double exercise150(double[] numberDouble)
    {
        double soAmLonNhat = numberDouble.Where(num => num < 0).DefaultIfEmpty(0).Max();
        return soAmLonNhat;
    }

    //exercise 151
    static int exercise151(int[] numberInt)
    { 
        int soNguyenToLonNhat = numberInt.Where(IsPrime).DefaultIfEmpty(0).Max();
        return soNguyenToLonNhat;
    }

    //exericse 152
    static int exercise152(int[] numberInt)
    {
        int soHoanThienLonNhat = numberInt.Where(IsPerfectNumber).DefaultIfEmpty(0).Min();
        return soHoanThienLonNhat;
    }

    //exercise 153
    static int exercise153(int[] numberInt)
    {
        int soChanNhoNhat = numberInt.Where(num => num % 2 == 0).DefaultIfEmpty(-1).Min();
        return soChanNhoNhat;
    }

    //exercise 154
    static int exercise154(double[] numberDouble)
    {
        int viTriAmLonNhat = Array.IndexOf(numberDouble, numberDouble.Where(num => num < 0).DefaultIfEmpty(double.NegativeInfinity).Max());
        return viTriAmLonNhat = viTriAmLonNhat < 0 ? -1 : viTriAmLonNhat;
    }
}

public abstract class exerciseNeedUse
{
    public abstract int exercise138(int[] array);
}