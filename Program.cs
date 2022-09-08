WorkWithIntegers();
OrderPrecedence();
testLimits();
WorkWithDoubles();
workWithDecimals();

double circle = (2.50*2.50)*Math.PI;
Console.WriteLine(circle);

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

void WorkWithDoubles(){
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double e = 19;
double f = 23;
double g = 8;
double h = (e + f) / g;
Console.WriteLine(h);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of doubles are {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

Console.WriteLine(e+f/c*(a-g)+b);
}


void workWithDecimals(){
decimal max = decimal.MaxValue;
decimal min = decimal.MinValue;
Console.WriteLine($"The range of decimels are {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a/b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);


}
