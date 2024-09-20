
double bai7(double n) {
    double sum = 0;
     if(n == 0){
        return sum;
    }
    for(double i = 1; i <= n; i++){
        sum += i/(i+1);
    }
    return Math.Round(sum,2);
}
Console.WriteLine($"bai tap 7: {bai7(6)}");

// lession 8
double bai8(double n) {
    double sum = 0.5;
    if(n == 0){
        return sum;
    }else{
        for(double i = 1; i <= n; i++){
            sum += (i*2 + 1)/(2*i+2);
        }
        return Math.Round(sum,2);
    }
}
Console.WriteLine($"bai tap 8: {bai8(6)}");

// lession 9
double bai9(double n) {
    double sum = 0;
    if(n == 0){
        return 0;
    }
    sum = 1;
    for(double i = 1; i <= n; i++){
        sum *= i;
    }
    return sum;
}
Console.WriteLine($"bai tap 9: {bai9(6)}");


double bai10(double x, double n) {
    double result = 0;
     if(n == 0 || x == 0){
        return 0;
    }
    result = 1;
    for (double i = 0; i < n; i++)
    {
        result *= x;
    }
    return result;
}
Console.WriteLine($"bai tap 10: {bai10(6, 2)}");

// lession 11
double bai11(double n) {
    double sum = 1;
    if(n == 0){
        return sum;
    }
        for(double i = 1; i <= n; i++){
            sum *= i;
        }
        return sum;
   
}

Console.WriteLine($"bai tap 11: {bai11(6)}");


double bai12(int n) {
    double sum = 0;
    int x = 8; 
    int currentPower = x;
    if(n == 0 || x == 0){
        return sum;
    }

    for (int i = 1; i <= n; i++)
    {
        sum += currentPower;
        currentPower *= x;
    }

    return sum;
}

Console.WriteLine($"bai tap 12: {bai12(6)}");


double bai13(int n) {
    double sum = 0;
    int x = 8; 
    if(n == 0 || x == 0){
        return sum;
    }
    
    int currentPower = x*x;

    for (int i = 1; i <= n; i++)
    {
        sum += currentPower;
        currentPower *= x*x;
    }

    return sum;
}

Console.WriteLine($"bai tap 13: {bai13(6)}");


double bai14(int n) {
    double sum = 0;
    int x = 8; 
    int currentPower = x; 
    if(n == 0 || x == 0){
        return sum;
    }

    for (int i = 1; i <= n; i++)
    {
        sum += currentPower;
        currentPower *= x * x; 
    }

    return sum;
}

Console.WriteLine($"bai tap 14: {bai14(6)}");


double bai15(int n){
    double sum = 0;
    if (n == 0){
       return sum;
    }

    double denomirator = 0;
    for (int i = 1; i <= n; i++){
        denomirator += i;
        sum += 1.0 / denomirator;
    }
    return sum;
 }

Console.WriteLine($"bai tap 15: {bai15(6)}");
