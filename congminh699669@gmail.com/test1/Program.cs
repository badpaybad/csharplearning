﻿// lession 1
long excercise1(long n) {
    long sum = n * (n+1) / 2;
    return sum;
}

// lession 2
int excercise2(int n) {
    int sum = n *  (n+1) * (2*n + 1) / 6;
    return sum;
}

// lession 3
double excercise3(double n) {
    double sum = 0;
    for(double i = 1; i <= n; i++){
        sum += 1/i;
    }
    return Math.Round(sum,2);
}

// lession 4
double excercise4(double n) {
    double sum = 0;
    for(double i = 1; i <= n; i++){
        sum += 1/(i*2);
    }
    return Math.Round(sum,2);
}

// lession 5
double excercise5(double n) {
    double sum = 0;
    if(n == 0) {
        return 1;
    }else{
        sum = 1;
        for(double i = 1; i <= n; i++){
            sum += 1/(i*2 + 1);
        }
        return Math.Round(sum,2);
    }
}

// lession 6
double excercise6(double n) {
    double sum = 0;
    for(double i = 1; i <= n; i++){
        sum += 1/(i* (i+1));
    }
    return Math.Round(sum,2);
}

// lession 7
double excercise7(double n) {
    double sum = 0;
    for(double i = 1; i <= n; i++){
        sum += i/(i+1);
    }
    return Math.Round(sum,2);
}

// lession 8
double excercise8(double n) {
    double sum = 0;
    if(n == 0){
        return 0.5;
    }else{
        sum = 0.5;
        for(double i = 1; i <= n; i++){
            sum += (i*2 + 1)/(2*i+2);
        }
        return Math.Round(sum,2);
    }
}

// lession 9
double excercise9(double n) {
    double sum = 1;
    for(double i = 1; i <= n; i++){
        sum *= i;
    }
    return sum;
}


// lession 10
double excercise10(double x, double n) {
    double result = 1;
    for (double i = 0; i < n; i++)
    {
        result *= x;
    }
    return result;
}

// lession 11
double accumulation(double n) {
    double sum = 0;
    if(n == 0){
        return 1;
    }else{
        sum = 1;
        for(double i = 1; i <= n; i++){
            sum *= i;
        }
        return sum;
    }
   
}

double excercise11(double n) {
    double result = 0;
    for (double i = 1; i <= n; i++)
    {
        result += excercise9(i);
    }
    return result;
}

// lession 12
double excercise12(int x, int n) {
    double sum = 0;
    int currentPower = x;

    for (int i = 1; i <= n; i++)
    {
        sum += currentPower;
        currentPower *= x;
    }

    return sum;
}


// lession 13
double excercise13(int x, int n) {
    double sum = 0;
    int currentPower = x*x;

    for (int i = 1; i <= n; i++)
    {
        sum += currentPower;
        currentPower *= x*x;
    }

    return sum;
}


// lession 14
double excercise14(int x, int n) {
    double sum = 0;
    int currentPower = x; // Bắt đầu với x^1

    for (int i = 1; i <= n; i++)
    {
        sum += currentPower;
        currentPower *= x * x; // Tính x^(2i+1) bằng cách nhân thêm x^2 vào x^(2i-1)
    }

    return sum;
}


Console.WriteLine("Result exercise 1: " + excercise1(1000000));
Console.WriteLine("Result exercise 2: " + excercise2(3));
Console.WriteLine("Result exercise 3: " + excercise3(5));
Console.WriteLine("Result exercise 4: " + excercise4(5));
Console.WriteLine("Result exercise 5: " + excercise5(1));
Console.WriteLine("Result exercise 6: " + excercise6(2));
Console.WriteLine("Result exercise 7: " + excercise7(6));
Console.WriteLine("Result exercise 8: " + excercise8(1));
Console.WriteLine("Result exercise 9: " + excercise9(10));
Console.WriteLine("Result exercise 10: " + excercise10(2,3));
Console.WriteLine("Result exercise 11: " + excercise11(3));
Console.WriteLine("Result exercise 12: " + excercise12(2,3));
Console.WriteLine("Result exercise 13: " + excercise13(2,3));
Console.WriteLine("Result exercise 14: " + excercise14(2,3));