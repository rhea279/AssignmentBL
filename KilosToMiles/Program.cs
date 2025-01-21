using System;
class MyProject{
static void Main(String[] Args){
Console.WriteLine("enter the kilometres");
float kilo=float.Parse(Console.ReadLine());
float miles=kilo*0.621371f;
Console.WriteLine($"{kilo} in miles: {miles}");
}
}