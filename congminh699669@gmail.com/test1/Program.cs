int excercise1(int n) {
    int sum = n *  (n+1) / 2;
    return sum;
}

int excercise2(int n) {
    int sum = n *  (n+1) * (2*n + 1) / 6;
    return sum;
}

double excercise3(double n) {
    double sum = 0;
    for(double i = 1; i <= n; i++){
        sum += 1/i;
    }
    return Math.Round(sum,2);
}
Console.WriteLine("Result exercise 1: " + excercise1(5));
Console.WriteLine("Result exercise 2: " + excercise2(3));
Console.WriteLine("Result exercise 3: " + excercise3(5));