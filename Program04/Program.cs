﻿using System;
class Program04
{
static void Main(string[] args)
{
Console.Write("Enter the radius of the circle: ");
double radius = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
}
}