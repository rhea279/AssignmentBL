using System;
class MyProject{
static void Main(String[] Args){ Console.WriteLine("enter the length of the rectangle");
int length=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the width of the rectangle");
int width=Convert.ToInt32(Console.ReadLine());
int peri=2*(length+width);
Console.WriteLine($"the perimeter of a rectangle is: {peri}");
}
}