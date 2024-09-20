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

// // lession 33
double excercise33(int n){
    if (n == 1)
        return Math.Sqrt(2);
    return Math.Sqrt(2 + excercise33(n - 1));
}


// // lession 34
double excercise34(int n){
    if (n == 1)
        return Math.Sqrt(1);
    return Math.Sqrt(n + excercise34(n - 1));
}


// // lession 35
double excercise35(int n){
    if (n == 1)
        return Math.Sqrt(1);
    return Math.Sqrt(n + excercise35(n - 1));
}

// lession 36
static double Factorial(int n){
    if (n == 0 || n == 1)
        return 1;
    return n * Factorial(n - 1);
}

static double excercise36(int n){
    if (n == 1)
        return Math.Sqrt(Factorial(1));
    return Math.Sqrt(Factorial(n) + excercise36(n - 1));
}

// lession 37
double excercise37(int n) {
    if (n == 0)
        return 0;
    double result = Math.Sqrt(2);
    for (int i = 3; i <= n; i++)
    {
        result = Math.Pow((i + result), (double)1 / i);
    }
    return result;
}

// lession 38
double excercise38(int n){
    if (n == 0)
        return 0;
    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        result = Math.Pow((i + result), (double)1 / (i + 1));
    }
    return result;
}

// lession 39
double excercise39(int n){
    if (n == 0)
        return 0;
    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        int value = 1;
        for (int j = 1; j <= i; j++)
        {
            value *= j;
        }
        result = Math.Pow((value + result), (double)1 / (i + 1));
    }
    return result;
}

// lession 40
double excercise40(int n, int x){
    double result = 0;
    for (int i = 1; i <= n; i++)
    {
        result = Math.Sqrt(Math.Pow(x, i) + result);
    }
    return result;
}

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
Console.WriteLine("Result exercise 33: " + excercise33(10));
Console.WriteLine("Result exercise 34: " + excercise34(10));
Console.WriteLine("Result exercise 35: " + excercise35(10));
Console.WriteLine("Result exercise 36: " + excercise36(10));
Console.WriteLine("Result exercise 37: " + excercise37(10));
Console.WriteLine("Result exercise 38: " + excercise38(10));
Console.WriteLine("Result exercise 39: " + excercise39(10));
Console.WriteLine("Result exercise 40: " + excercise40(10,4));