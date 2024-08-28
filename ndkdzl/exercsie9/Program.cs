
double exercise82(float a, float b, float c)
{
    // cach 1
    //float max = a;
    //if( max < b)
    //{
    //    max = b ;
    //}

    //if(max < c)
    //{
    //    max = c;
    //}

    //return max;

    // cach 2

    return a > b && a > c ? a : (b > c ? b : c);
    
}

bool exercise83(float a, float b)
{
    // cach 1
    if(a > 0 && b > 0)
    {
        return true;
    }

    return false;
}

string exericse84(int a, int b)
{
    if( a == 0 && b == 0)
    {
        return "Phuong trinh co vo so nghiem";
    }
    else
    {
        if(a == 0 && b != 0)
        {
            return "Phuong trinh vo nghiem";
        }

        if(a != 0 && b == 0)
        {
            return "Phuong trinh co vo so nghiem";
        }

        if(b != 0 && a != 0)
        {
            return "Phuong trinh co nghiem x = " + (-b / a);
        }

        return "Khong the nao";
    }
}

double exericse122(double[] array)
{
    if(array.Length < 0)
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

int exericse123(int[] array)
{
    //Viết hàm tìm một vị trí mà giá trị tại vị trí đó là một giá trị nhỏ nhất 
    //trong mảng một chiều các số nguyên
    if (array.Length < 0)
    {
        return 0;
    }
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return Array.IndexOf(array, min);
}

bool exericse124(int[] array)
{
    //Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ
    //hơn 2004 hay không?
    if (array.Length < 0)
    {
        return false ;
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 2004 && array[i] %2 == 0)
        {
            return true;
        }
    }
    return false;
}

int exercise125(int[] array)
{
    // Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng.
    if (array.Length < 0)
    {
        return 0;
    }

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        bool flag = false;
        for(int j = 2; j < array[i]; j++)
        {
            if (array[i] % j == 0)
            {
                flag = true;
            }
        }

        if (!flag && array[i] < 100 && array[i] > 1)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(exercise82(2250,22220,2223));
Console.WriteLine(exercise83(2250,-22220));
Console.WriteLine(exericse84(0 ,0));
Console.WriteLine(exericse84(1 ,1));
Console.WriteLine(exericse84(0 ,1));
Console.WriteLine(exericse84(1 ,0));
Console.WriteLine(exericse122([1.6, 5, -3.2, 2.5, 6]));
Console.WriteLine(exericse123([1,-2,5,2,0]));
Console.WriteLine(exericse124([1,-2,5,2,0]));
Console.WriteLine(exercise125([3,4,5,6,11, 20]));
Console.ReadLine();