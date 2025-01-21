using System;
class PowerCal{
static void Main(String[] Args){ Console.WriteLine("enter the first no.");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second no.");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the third no.");
int c=Convert.ToInt32(Console.ReadLine());
int avg=(a+b+c)/3;
Console.WriteLine($"the average of three numbers is: {avg}");
}
}