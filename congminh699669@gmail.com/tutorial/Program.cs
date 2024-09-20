
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
      variables();
      dataType();
      typeCasting();
      userInput();
      operatior();
    }

    static void variables(){
        // type (int, bool, double, char, string) variableName = value
        int age = 18;
        bool isShow = true;
        double total = 1000.69;
        char key = 'c';
        string fullName = "Cong Minh";

        Console.WriteLine(age);    
        Console.WriteLine(isShow);    
        Console.WriteLine(total);    
        Console.WriteLine(key);    
        Console.WriteLine(fullName);    

        // constant
        const int myNum = 15;
        Console.WriteLine(myNum);    

        // multiple variable
        int x = 15, y = 15, z = 15;
        Console.WriteLine(x + y + z);
    }

    static void dataType(){
        int valueA = 12; // from -2,147,483,648 to 2,147,483,647
        long valueB = 20000000000; // from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        float valueC = 1.78F; // Sufficient for storing 6 to 7 decimal digits
        bool isShow = true;
        double total = 1000.69;
        char key = 'c';
        string fullName = "Cong Minh";

        Console.WriteLine(valueA);  
        Console.WriteLine(valueB);  
        Console.WriteLine(valueC);  
        Console.WriteLine(isShow);  
        Console.WriteLine(total);  
        Console.WriteLine(key);  
        Console.WriteLine(fullName);  
    }

    static void typeCasting(){
        // char -> int -> long -> float -> double
        // double -> float -> long -> int -> char

        int myIntA = 9;
        double myDoubleA = myIntA;       // Automatic casting: int to double

        Console.WriteLine(myIntA);      // Outputs 9
        Console.WriteLine(myDoubleA);   // Outputs 9

        double myDouble = 9.78;
        int myInt = (int) myDouble;    // Manual casting: double to int

        Console.WriteLine(myDouble);   // Outputs 9.78
        Console.WriteLine(myInt);      // Outputs 9


        int myIntConvert = 10;
        double myDoubleConvert = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myIntConvert));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myIntConvert));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDoubleConvert));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

    }
 
    static void userInput(){
        Console.WriteLine("Enter your age:");
        string age = Console.ReadLine();
        Console.WriteLine("Your age is: " + age);
    }
 
    static void operatior(){
        // +, -, *, /, %, ++, --
        int numberA = 10;
        int numberB = 5;

        int sum = numberA + numberB;
        int sub = numberA - numberB;
        int tich = numberA * numberB;
        float chia = numberA / numberB;
        int chiaphantram = numberA % numberB;
        numberA++;
        numberB--;

        Console.WriteLine(sum);
        Console.WriteLine(sub);
        Console.WriteLine(tich);
        Console.WriteLine(chia);
        Console.WriteLine(chiaphantram);
        Console.WriteLine(numberA);
        Console.WriteLine(numberB);
    }
 
 
  }
}