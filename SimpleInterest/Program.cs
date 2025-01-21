using System;
class SimpleInterest{
static void Main(String[] Args){ Console.WriteLine("enter the principle amount");
double principle=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the Rate");
double rate=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the Time");
double Time=Convert.ToDouble(Console.ReadLine());
double SI=(principle*rate*Time)/100;
Console.WriteLine($"the Simple Interest is: {SI}");
}
}