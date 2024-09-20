// lession 22
int excercise22(int n) {
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            sum *= i;
        }
    }
    return sum;
}

// lession 23
int excercise23(int n) {
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            sum ++;
        }
    }
    return sum;
}

// lession 24
List<int> excercise24(int n)
{
    List<int> result = [];
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 == 1)
        {
            result.Add(i);
        }
    }
    result.Sort();
    return result;
}

// lession 25
int excercise25(int n) {
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 == 0)
        {
            sum += i;
        }
    }
    return sum;
}


// lession 26
double excercise26(int n) {
    double result = 1;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 == 1)
        {
            result *= i;
        }
    }
    return result;
}

// lession 27
int excercise27(int n) {
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0 && i % 2 == 0)
        {
            sum ++;
        }
    }
    return sum;
}

// lession 28
int excercise28(int n){
    int sum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    return sum;
}

// lession 29
double excercise29(double n) {
    double result = -1;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0 && i % 2 == 1 && i > result)
        {
            result = i;
        }
    }
    return result;
}

// lession 30
bool excercise30(int n) {
    bool check = false;
    int sum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
        }
    }
    check = sum == n;
    return check;
}


// lession 31
bool excercise31(int n) {
    bool result = false;
    int count = 0;
    for (double i = 0; i <= n; i++){
         if (n % i == 0)
        {
            count ++;
        }
    }
    result = count == 2;
    return result;
}

// lession 32
bool excercise32(double n) {
    bool result = false;
    double canBacHai = Math.Sqrt(n);
    
    result = canBacHai == (int)canBacHai;
    return result;
}

// double excercise11(double n) {
//     double result = 0;
//     for (double i = 1; i <= n; i++)
//     {
//         result += excercise9(i);
//     }
//     return result;
// }

// // lession 33
// double excercise12(int x, int n) {
//     double sum = 0;
//     int currentPower = x;

//     for (int i = 1; i <= n; i++)
//     {
//         sum += currentPower;
//         currentPower *= x;
//     }

//     return sum;
// }


// // lession 34
// double excercise13(int x, int n) {
//     double sum = 0;
//     int currentPower = x*x;

//     for (int i = 1; i <= n; i++)
//     {
//         sum += currentPower;
//         currentPower *= x*x;
//     }

//     return sum;
// }


// // lession 35
// double excercise14(int x, int n) {
//     double sum = 0;
//     int currentPower = x;

//     for (int i = 1; i <= n; i++)
//     {
//         sum += currentPower;
//         currentPower *= x * x;
//     }

//     return sum;
// }

// // lession 36
// double excercise15(int n) {
//     double totalSum = 1.0;
//     int partialSum = 1;  

//     for (int i = 2; i <= n; i++)
//     {
//         partialSum += i; 
//         totalSum += 1.0 / partialSum; 
//     }

//     return totalSum;
// }

// // lession 37
// double excercise16(double x, int n) {
//     double totalSum = x;  
//     int partialSum = 1;   

//     for (int i = 2; i <= n; i++)
//     {
//         partialSum += i; 
//         totalSum += Math.Pow(x, i) / partialSum; 
//     }

//     return totalSum;
// }

// // lession 38
// double excercise17(double x, int n){
//     double totalSum = x;
//     double factorial = 1;

//     for (int i = 2; i <= n; i++)
//     {
//         factorial *= i;
//         totalSum += Math.Pow(x, i) / factorial;
//     }

//     return totalSum;
// }

// // lession 39
// double excercise18(double x, int n){
//     double totalSum = 1;
//     double factorial = 1;

//     for (int i = 1; i <= n; i++)
//     {
//         factorial *= (2 * i - 1) * (2 * i);
//         totalSum += Math.Pow(x, 2 * i) / factorial;
//     }

//     return totalSum;
// }

// // lession 40
// double excercise19(double x, int n){
//     double totalSum = 1 + x;
//     double factorial = 1;

//     for (int i = 1; i <= n; i++)
//     {
//         factorial *= (2 * i) * (2 * i + 1);
//         totalSum += Math.Pow(x, 2 * i + 1) / factorial;
//     }

//     return totalSum;
// }

// // lession 41
// List<int> excercise20(int n)
// {
//     List<int> result = [];
//     for (int i = 1; i <= Math.Sqrt(n); i++)
//     {
//         if (n % i == 0)
//         {
//             result.Add(i);
//             if (i != n / i)
//             {
//                 result.Add(n / i);
//             }
//         }
//     }
//     result.Sort();
//     return result;
// }


// // lession 42
// int excercise21(int n){
//     int sum = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         if (n % i == 0)
//         {
//             sum += i;
//         }
//     }
//     return sum;
// }

Console.WriteLine("Result exercise 22: " + excercise22(10));
Console.WriteLine("Result exercise 23: " + excercise23(10));
Console.WriteLine("Result exercise 24: " + string.Join(", ", excercise24(10)));
Console.WriteLine("Result exercise 25: " + excercise25(10));
Console.WriteLine("Result exercise 26: " + excercise26(21));
Console.WriteLine("Result exercise 27: " + excercise27(10));
Console.WriteLine("Result exercise 28: " + excercise28(10));
Console.WriteLine("Result exercise 29: " + excercise29(1000));
Console.WriteLine("Result exercise 30: " + excercise30(8128));
Console.WriteLine("Result exercise 31: " + excercise31(7));
Console.WriteLine("Result exercise 32: " + excercise32(144));
// Console.WriteLine("Result exercise 6: " + excercise6(2));
// Console.WriteLine("Result exercise 7: " + excercise7(6));
// Console.WriteLine("Result exercise 8: " + excercise8(1));
// Console.WriteLine("Result exercise 9: " + excercise9(10));
// Console.WriteLine("Result exercise 10: " + excercise10(2,3));
// Console.WriteLine("Result exercise 11: " + excercise11(3));
// Console.WriteLine("Result exercise 12: " + excercise12(2,3));
// Console.WriteLine("Result exercise 13: " + excercise13(2,3));
// Console.WriteLine("Result exercise 14: " + excercise14(2,3));
// Console.WriteLine("Result exercise 15: " + excercise15(5));
// Console.WriteLine("Result exercise 16: " + excercise16(2,5));
// Console.WriteLine("Result exercise 17: " + excercise17(2,5));
// Console.WriteLine("Result exercise 18: " + excercise18(2,5));
// Console.WriteLine("Result exercise 19: " + excercise19(2,5));
// Console.WriteLine("Result exercise 20: " + string.Join(", ", excercise20(10)));
// Console.WriteLine("Result exercise 21: " + excercise21(10));