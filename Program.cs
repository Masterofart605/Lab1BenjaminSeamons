﻿//WorkWithIntegers();
//OrderPrecedence();
//testLimits();




void WorkWithIntegers()
{
//Addition
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

//Subtraction
c = a - b;
Console.WriteLine(c);

//Multipication
c = a * b;
Console.WriteLine(c);

//Division
c = a / b;
Console.WriteLine(c);

//Random stuff
c = a+b/a-b*a;
Console.WriteLine(c);
}
void OrderPrecedence(){
    int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c + a * (b + c);
Console.WriteLine(d);

int e = 7;
int f = 4;
int g = 3;
int h = (e+f)/g;
Console.WriteLine(h);
}

void testLimits(){
int a =7;
int b = 4;
int c = 3;
int d = (a + b ) / c;
int e = (a + b ) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
}