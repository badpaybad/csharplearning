
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



Console.WriteLine(exercise82(2250,22220,2223));
Console.WriteLine(exercise83(2250,-22220));
Console.WriteLine(exericse84(0 ,0));
Console.WriteLine(exericse84(1 ,1));
Console.WriteLine(exericse84(0 ,1));
Console.WriteLine(exericse84(1 ,0));
Console.ReadLine();